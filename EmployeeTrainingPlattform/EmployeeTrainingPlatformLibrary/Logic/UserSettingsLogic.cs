using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace EmployeeTrainingPlatformLibrary.Logic
{
    public class UserSettingsLogic
    {
        public IDataConnection db = GlobalConfig.Connection;
        public GeneralDepartmentLogic departmentLogic = new GeneralDepartmentLogic();

        /// <summary>
        /// Update user credentials and employee
        /// </summary>
        /// <param name="firstName">First name of employee</param>
        /// <param name="lastName">Last name of employee</param>
        /// <param name="department">Department of employee</param>
        /// <param name="emailAddress">Email Address of user</param>
        /// <param name="currentPassword">Current password of user</param>
        /// <param name="newPassword">New password of user</param>
        public void ChangeUserSettings(string firstName, string lastName, string department, string emailAddress, string currentPassword, string newPassword)
        {
            UpdateUserAccount(emailAddress, currentPassword, newPassword);

            UpdateEmployee(firstName, lastName, department);

        }

        /// <summary>
        /// Update user account
        /// </summary>
        /// <param name="emailAddress">Email Address of user</param>
        /// <param name="currentPassword">Current password of user</param>
        /// <param name="newPassword">New password of user</param>
        /// 
        private void UpdateUserAccount(string emailAddress, string currentPassword, string newPassword)
        {

            UpdateUserAccountEmailAddress(emailAddress);

            UpdateUserAccountPassword(currentPassword, newPassword);

        
        }

        /// <summary>
        /// Update password of user account
        /// </summary>
        /// <param name="currentPassword">current password of user</param>
        /// <param name="newPassword">new password of user</param>
        private void UpdateUserAccountPassword(string currentPassword, string newPassword)
        {
            //Check if passwords were entered OR if new password and current password are the same. if so, s
            if ((newPassword.Length > 0 && currentPassword.Length > 0) || (!newPassword.Equals(currentPassword)))
            {
                UserAccountEntry userAccount = db.GetUserAccountCredentials(Global.employee.EmailAddress);

                if (userAccount != null)
                {

                    //Check if entered current password really is current password. If so, update user account with updated credentials
                    if (PasswordCryptoLogic.VerifyPassword(currentPassword, userAccount.PasswordSalt, userAccount.PasswordHash))
                    {


                        UserAccountEntry userAccountNew = new UserAccountEntry(Global.employee.EmailAddress, newPassword);
                        userAccountNew.EmployeeId = Global.employee.Id;

                        //Update User Account DB
                        db.UpdateUserAccountPassword(userAccountNew);

                    }
                    else
                    {
                        throw new TrainingPlatformException("Your current password does not match up with the entered current password.");
                    }

                }
                else
                {
                    Debug.WriteLine("No user account was found");
                    throw new Exception();
                }

            }
        }
        /// <summary>
        /// Update email address of user account
        /// </summary>
        /// <param name="emailAddress">email address</param>
        private void UpdateUserAccountEmailAddress(string emailAddress)
        {

            //Check if email address is empty. If so, assign current email address to emailAddress to 
            if (emailAddress.Length == 0)
            {
                emailAddress = Global.employee.EmailAddress;
            }

            //Update email address
            db.UpdateUserAccountEmailAddress(emailAddress, Global.employee.Id);

            //assignnew email address to user
            Global.employee.EmailAddress = emailAddress;
        }

        /// <summary>
        /// Update employee account
        /// </summary>
        /// <param name="firstName">First name of employee</param>
        /// <param name="lastName">Last name of employee</param>
        /// <param name="department">Department of employee</param>
        private void UpdateEmployee(string firstName, string lastName, string department)
        {


            Employee tmp_Employee = Global.employee;

            //Check if names are empty. if so, assign current names to variables
            if(firstName.Length > 0)
            {
                tmp_Employee.FirstName = firstName;
            }

            if(lastName.Length > 0)
            {
                tmp_Employee.LastName = lastName;
            }


            tmp_Employee.Department = departmentLogic.MapStringToDepartment(department);
            //write updated employee to database
            db.UpdateEmployee(tmp_Employee);

            Global.employee.FirstName = tmp_Employee.FirstName;
            Global.employee.LastName = tmp_Employee.LastName;
            Global.employee.Department = tmp_Employee.Department;


        }

      

    }
}
