using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Logic
{
    public class GeneralTrainingBookingLogic
    {

        public IDataConnection db;

        public GeneralTrainingBookingLogic()
        {
            db = GlobalConfig.Connection;
        }

        public GeneralTrainingBookingLogic(IDataConnection connection)
        {
            db = connection;
        }

        GeneralTrainingLogic trainingLogic = new GeneralTrainingLogic();

        /// <summary>
        /// Checks if training has a certain training status
        /// </summary>
        /// <param name="training">Title of training</param>
        /// <param name="status">supposed status of training</param>
        /// <returns> true if training has status and false if it hasn't</returns>
        public bool HasTrainingStatus(string training, TrainingStatus status)
        {
            Dictionary<string, TrainingStatus> bookingList = db.GetTrainingBooking(Global.employee.Id);

            TrainingStatus tmp_status;

            if (bookingList.TryGetValue(training, out tmp_status))
            {
                if ( tmp_status == status)
                    return true;
            }


            return false;
        }

        /// <summary>
        /// Get booking entries of employee 
        /// </summary>
        /// <returns>Dictionary with booking entries, containing title of training and status of training </returns>
        public Dictionary<string,string> GetTrainingBooking()
        {
            Dictionary<string, string> bookingList = new Dictionary<string, string>();

            Dictionary<string, TrainingStatus> currentBookingList = db.GetTrainingBooking(Global.employee.Id);

            foreach (var bookingEntry in currentBookingList)
            {
                bookingList.Add(bookingEntry.Key, bookingEntry.Value.ToString());
            }
            return bookingList;
        }

        public Dictionary<string, TrainingStatus> GetTrainingBookingById(int employeeId)
        {
            Dictionary<string, TrainingStatus> bookingList = db.GetTrainingBooking(employeeId);

            return bookingList;
        }



        /// <summary>
        /// Start logic to delete booking entry
        /// </summary>
        /// <param name="title">title of training</param>
        public void DeleteBookingEntry(string title)
        {
            //get selected Training
            Training training = trainingLogic.GetSelectedTraining(title);

            //get current booking entries
            Dictionary<string, TrainingStatus> currentBookingList = db.GetTrainingBooking(Global.employee.Id);


            if (training != null)
            {

                //Check if training, which is supposed to be deleted, is an requirement for an already booked training. If so, don't delete it
                List<Training> trainings = db.GetTrainingToRequirement(title);
                List<string> trainingWithTitleAsReq = new List<string>();

                if(trainings.Count > 0 )
                {
                    foreach (var tmp_training in trainings)
                    {
                        if(currentBookingList.ContainsKey(tmp_training.Title))
                        {
                            trainingWithTitleAsReq.Add(tmp_training.Title);
                        }
                    }

                    //check if such trainings were found. If so, generate an error message containing thos trainings and throw an exception
                    if(trainingWithTitleAsReq.Count > 0)
                    {
                        StringBuilder errorMessage = new StringBuilder();

                        errorMessage.Append("This training is a requirement for following trainings and thus can not be deleted. Training/s: \n");

                        foreach (string tmp_title in trainingWithTitleAsReq)
                        {
                            errorMessage.Append(tmp_title + "\n");
                            
                        }

                        throw new TrainingPlatformException(errorMessage.ToString());
                    }
                }

                try
                {

                    currentBookingList.Remove(title);
                }
                catch (Exception ex)
                {
                    Debug.Fail($"DeleteBookingEntry: {ex.Message}");
                }

                //Delete booking entry of selected training
                db.DeleteTrainingBookingEntryOfEmployee(Global.employee.Id, training.Id);
                Global.employee.TrainingBooking = db.GetTrainingBooking(Global.employee.Id);
            }
            else
            {
                Debug.Fail($"Selected training with title '{title}' could not be found.");
                throw new TrainingPlatformException("The selected training could not be deleted. Please try again or contact an administrator.");
            }

        }

        public void UpdateTrainingStatus(int employeeId, string title, TrainingStatus status, bool isAdmin)
        {
            Training training = trainingLogic.GetSelectedTraining(title);

            if(training == null)
            {
                Debug.Fail($"No training with title {title} was found. ");
                throw new Exception();
            }


            if(isAdmin == false)
            {
                Global.employee.TrainingBooking.Remove(title);
                Global.employee.TrainingBooking.Add(title, status);
            }
            db.UpdateTrainingBookingStatus(employeeId, training.Id, (int)status);
        }

      
    }
}
