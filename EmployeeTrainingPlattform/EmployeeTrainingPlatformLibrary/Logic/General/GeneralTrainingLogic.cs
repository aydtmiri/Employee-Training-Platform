using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Logic
{
    public class GeneralTrainingLogic
    {
        public IDataConnection db;

        public GeneralTrainingLogic()
        {
            db = GlobalConfig.Connection;
        }

        public GeneralTrainingLogic(IDataConnection connection)
        {
            db = connection;
        }

        /// <summary>
        /// Get Training with given title
        /// </summary>
        /// <param name="title">Title of training</param>
        /// <returns></returns>

        public Training GetSelectedTraining(string title)
        {
            List<Training> trainings = db.GetTrainings();

            foreach (var training in trainings)
            {
                if (training.Title.Equals(title))
                {

                    return training;
                }
            }

            return null;
        }

        /// <summary>
        /// Get corresponding department to training
        /// </summary>
        /// <param name="title">Title of training</param>
        /// <returns>Corresponding training</returns>
        public string GetDepartmentOfTraining(string title)
        {
            foreach (var training in Training.Trainings)
            {
                if (training.Title.Equals(title))
                {

                    return training.Department.ToString();
                }
            }

            return " - ";

        }

        /// <summary>
        /// Get trainings which have given training as requirement
        /// </summary>
        /// <param name="requirement">Title of requirement</param>
        /// <returns>List with all trainings that have given training as requirement</returns>
        public List<Training> GetTrainingToRequirement(string requirement)
        {
            List<Training> trainings = db.GetTrainingToRequirement(requirement);
            return trainings;
        }
    }
}
