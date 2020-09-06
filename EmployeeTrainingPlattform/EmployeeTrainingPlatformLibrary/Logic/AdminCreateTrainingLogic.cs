using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Logic.General;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Logic
{
    public class AdminCreateTrainingLogic
    {
        private IDataConnection db = GlobalConfig.Connection;
        private GeneralPermissionLogic permissionLogic = new GeneralPermissionLogic();

        /// <summary>
        /// Create training
        /// </summary>
        /// <param name="title">Title of training</param>
        /// <param name="department">Department which corresponds to training</param>
        /// <param name="requirement">Prerequisite of training</param>
        /// <param name="description">Description of training</param>
        public void CreateTraining(string title, string department, string requirement, string description)
        {
            if (permissionLogic.HasUserPermission(Permission.PERM_CREATE_TRAINING))
            {

                if (requirement.Length == 0)
                {
                    requirement = null;
                }

                Training training = new Training(title, department, requirement, description);

                try
                {
                    training = db.CreateTraining(training);
                }
                catch (SqlException e) when (e.Number == 2627)
                {
                    throw new TrainingPlatformException($"A training with the title '{training.Title}' already exists.");
                }

                Training.Trainings.Add(training);
            }
            else
            {
                throw new NoPermissionException("You do not have the permission to do create a training.");
            }

        }
    }
}
