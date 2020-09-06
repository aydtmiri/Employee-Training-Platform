using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Logic
{
    public class EmployeeBookTrainingLogic
    {
        public IDataConnection db = GlobalConfig.Connection;

        /// <summary>
        /// Book training after validating if booking is valid
        /// </summary>
        /// <param name="title">Title of selected training</param>
        public void BookTraining(string title)
        {
            Training training = null;

            foreach (var tmp_training in Training.Trainings)
            {
                if (tmp_training.Title.Equals(title))
                {
                    training = tmp_training;
                    break;
                }
            }



            if (training == null)
            {
                Debug.Fail($"No training with the title {title} found.");
                throw new Exception();

            }


            // Check if employee has already booked this training and throw an exception in this case
            if (Global.employee.TrainingBooking.ContainsKey(training.Title))
            {
                throw new TrainingPlatformException("You already booked this training.");
            }

            // check if there is no requirement. If so, book the training
            if (training.Requirement == null)
            {
                Global.employee.TrainingBooking.Add(training.Title, TrainingStatus.Booked);
                db.CreateTrainingBooking(Global.employee.Id, training.Id, (int)TrainingStatus.Booked);
                return;
            }
            else
            {
                TrainingStatus tmp_status;

                //check if employee already booked the required training
                if(Global.employee.TrainingBooking.TryGetValue(training.Requirement, out tmp_status))
                {
                    //check if requirement is already completed.  If not, throw an exception
                    if(tmp_status.Equals(TrainingStatus.Completed))
                    {
                        Global.employee.TrainingBooking.Add(training.Title, TrainingStatus.Booked);
                        db.CreateTrainingBooking(Global.employee.Id, training.Id, (int)TrainingStatus.Booked);
                        return;
                    }
                    else
                    {
                        throw new TrainingPlatformException("You did not complete the required training yet. You can not book this training before completing the requirement. ");
                    }

                }
                else
                {
                    throw new TrainingPlatformException("You do not meet the requirements for this training. Please have a look at the required training.");
                }

                
            }
        }
    }
}
