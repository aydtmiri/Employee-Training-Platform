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
    public class LoginLogic
    {
        public IDataConnection db ;

        /// <summary>
        /// Login user to the platform using the username and password
        /// </summary>
        /// <param name="username">Username of user</param>
        /// <param name="password">Password of user</param>
        /// 
        public LoginLogic()
        {
            db = GlobalConfig.Connection;
        }

        public LoginLogic(IDataConnection connection)
        {
            db = connection;
        }

        /// <summary>
        /// Login with email and password
        /// </summary>
        /// <param name="emailAddress">Email address</param>
        /// <param name="password">Password</param>
        /// <returns>true if login successfull</returns>
        public bool Login(string emailAddress, string password)
        {
            //Get user account 
            UserAccountEntry userCredentials = db.GetUserAccountCredentials(emailAddress);
            if(userCredentials == null)
            {
                return false;
            }

            //verify password
            if (PasswordCryptoLogic.VerifyPassword(password, userCredentials.PasswordSalt, userCredentials.PasswordHash))
            {
                Employee employee = db.GetEmployeeById(userCredentials.EmployeeId);

                if(employee == null)
                {
                    Debug.WriteLine($"ERROR during retrieving employee with id {userCredentials.EmployeeId}");
                    throw new Exception();
                    
                }
                employee.EmailAddress = emailAddress;

                userCredentials = null;


                //Get all trainings
                Training.Trainings = db.GetTrainings();

                //Get all training bookings of current user
                employee.TrainingBooking = db.GetTrainingBooking(employee.Id);

                if (employee.Role.Equals(Role.ROLE_ADMIN))
                {
                    Employee.Employees = db.GetAllEmployees();
                }

                //assign employee object to global employee
                Global.employee = employee;


                return true;
            }

            return false;







        }
    }
}
