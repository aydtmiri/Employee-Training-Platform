using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;

namespace EmployeeTrainingPlatformLibrary.Logic
{
    
    public class GeneralEmployeeLogic
    {

        public IDataConnection db = GlobalConfig.Connection;


        /// <summary>
        /// Saves Employee using the input values
        /// </summary>
        /// <param name="firstname">First name of employee</param>
        /// <param name="lastname">Last name of employee</param>
        /// <param name="department">Name of department where employee works</param>
        public void SaveEmployee(string firstname, string lastname, string department)
        {
            Employee employee = new Employee(
                    firstname,
                    lastname,
                    department);


            db.CreateEmployee(employee);


        }

        public List<Employee> GetAllEmployees()
        {
            return db.GetAllEmployees();
        }

        public string GetFullName(Employee employee)
        {
            return employee.FirstName + " " + employee.LastName;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            Employee employee = db.GetEmployeeById(employeeId);
            //throw exception if no employee was found
            if (employee == null)
            {
                throw new Exception($"No employee found with id {employeeId}.");
            }

            return employee;
        }




    }
}
