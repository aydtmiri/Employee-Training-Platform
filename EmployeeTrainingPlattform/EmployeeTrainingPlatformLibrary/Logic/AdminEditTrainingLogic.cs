using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Logic.General;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Logic
{
    public class AdminEditTrainingLogic
    {
        public IDataConnection db = GlobalConfig.Connection;

        GeneralTrainingLogic trainingLogic = new GeneralTrainingLogic();
        GeneralDepartmentLogic departmentLogic = new GeneralDepartmentLogic();
        GeneralPermissionLogic permissionLogic = new GeneralPermissionLogic();

        public void DeleteTraining(int trainingId)
        {
            //Check if training is booked by employees and in status in process
            List<TrainingBookingEntry> entries = db.GetBookingsWithStatus(trainingId, (int)TrainingStatus.InProcess);

            //if not, proceed, else throw an exception
            if (entries.Count == 0)
            {

                db.DeleteTraining(trainingId);
                Training.Trainings = db.GetTrainings();

            }
            else
            {
                throw new TrainingPlatformException("There are employee which are currently undergo this training and therefor it can not be deleted.");
            }
        }

        /// <summary>
        /// Update Training with entered values
        /// </summary>
        /// <param name="title">Title of training</param>
        /// <param name="department">Department which corresponds to training</param>
        /// <param name="requirement">Prerequisite of training</param>
        /// <param name="description">Description of training</param>
        public void UpdateTraining(string originalTitle, string newTitle, string department, string requirement, string description)
        {

            //check if user set prerequisit of training to itself
            if (originalTitle.Equals(requirement))
            {
                throw new TrainingPlatformException("You can not set the prerequisite of this training to itself. Please choose another prerequsite");
            }


            //get original training
            Training originalTraining = trainingLogic.GetSelectedTraining(originalTitle);

            //check which values aren't empty. if they are not, assign new values to training object
            if (newTitle.Length > 0)
            {
                originalTraining.Title = newTitle;
            }
            if (!department.Equals("Select department"))
            {
                originalTraining.Department = departmentLogic.MapStringToDepartment(department);
            }
            if (requirement.Length > 0)
            {
                originalTraining.Requirement = requirement;
            }
            if (description.Length > 0)
            {
                originalTraining.Description = description;
            }

            //update training in dB
            db.UpdateTraining(originalTraining);

        }

    }
}

