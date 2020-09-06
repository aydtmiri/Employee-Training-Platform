using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;

namespace EmployeeTrainingPlatformLibrary.Logic
{
    public  class GeneralDepartmentLogic
    {

        public IDataConnection db = GlobalConfig.Connection;

        /// <summary>
        /// Returns all department names
        /// </summary>
        /// <returns>All departments names</returns>
        public List<string> GetAllDepartmentnames()
        {

            return db.GetDepartmentNames();
        }

        public Department MapStringToDepartment(string department)
        {
            Department mappedDepartment;

            switch (Regex.Replace(department, @"\s+", ""))
            {
                case "HR": mappedDepartment = Department.HR; break;
                case "Marketing": mappedDepartment = Department.Marketing; break;
                case "IT": mappedDepartment = Department.IT; break;
                default:
                    mappedDepartment = Department.IT;
                    break;
            }

            return mappedDepartment;
        }


    }
}
