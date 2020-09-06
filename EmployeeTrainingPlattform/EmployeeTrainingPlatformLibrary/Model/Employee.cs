using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Text;
using EmployeeTrainingPlatformLibrary.Model;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace EmployeeTrainingPlattformLibrary.Model
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(string firstname, string lastname, string department)
        {
            this.FirstName = firstname;
            this.LastName = lastname;

            switch (Regex.Replace(department, @"\s+", ""))
            {
                case "HR": this.Department = Department.HR;break;
                case "Marketing": this.Department = Department.Marketing;break;
                case "IT": this.Department= Department.IT;break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Unique identifier for employee
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First name of employee
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of employee
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Department where employee works
        /// </summary>
        public Department Department { get; set; }
        /// <summary>
        /// List which contains the booking of trainings
        /// </summary>
        public Dictionary<string, TrainingStatus> TrainingBooking { get; set; } = new Dictionary<string, TrainingStatus>();

        public string EmailAddress { get; set; }

        public Role Role { get; set; }

        public static List<Employee> Employees { get; set; }


    }
}
