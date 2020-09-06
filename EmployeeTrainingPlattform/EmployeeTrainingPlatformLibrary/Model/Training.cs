using EmployeeTrainingPlatformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmployeeTrainingPlattformLibrary.Model
{
    public class Training
    {
        public Training()
        {

        }

        public Training(string title, string department, string requirement, string description)
        {
            Title = title;

            switch (Regex.Replace(department, @"\s+", ""))
            {
                case "HR": this.Department = Department.HR; break;
                case "Marketing": this.Department = Department.Marketing; break;
                case "IT": this.Department = Department.IT; break;
                default:
                    break;
            }
       
            Requirement = requirement;
            Description = description;
        }

        /// <summary>
        /// List with all existing Trainings
        /// </summary>
        public static List<Training> Trainings { get; set; }
    
        /// <summary>
        /// Unique identifier for training
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title of training
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Description for training
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Department for which training is supposed to be
        /// </summary>
        public Department Department { get; set; }
        /// <summary>
        /// Training which has to be completed before booking current training
        /// </summary>
        public string Requirement { get; set; }



    }



}
