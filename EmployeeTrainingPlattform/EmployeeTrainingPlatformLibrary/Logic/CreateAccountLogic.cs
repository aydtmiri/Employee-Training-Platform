using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Logic.General;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System.Collections.Generic;

namespace EmployeeTrainingPlatformLibrary.Logic
{
    public class CreateAccountLogic
    {
        public IDataConnection db;

        public GeneralPermissionLogic permissionLogic = new GeneralPermissionLogic();

        public CreateAccountLogic()
        {
            db = GlobalConfig.Connection;
        }

        public CreateAccountLogic(IDataConnection connection)
        {
            db = connection;
        }

        /// <summary>
        /// Creates Employee and User Account
        /// </summary>
        /// <param name="firstname">Firstname of employee</param>
        /// <param name="lastname">Lastname of employee</param>
        /// <param name="department">Department of employee</param>
        /// <param name="emailaddress">Email Address of employee</param>
        /// <param name="password">Password of employee</param>
        public void CreateEmployee(string firstname, string lastname, string department, string emailaddress, string password)
        {
            //init employee object with given info
            Employee employee = new Employee(
                    firstname,
                    lastname,
                    department);


            UserAccountEntry userAccount = new UserAccountEntry(emailaddress, password);


            //create employee in dB
           db.CreateEmployeeUserAccount(employee, userAccount);


        }

       
    }
}
