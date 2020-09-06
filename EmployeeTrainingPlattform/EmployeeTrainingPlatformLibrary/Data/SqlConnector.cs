using Dapper;
using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

//@FirstName nvarchar(50),
//@LastName nvarchar(50),
//@Department int,
//@Role int,
//@id int = 0 output

namespace EmployeeTrainingPlatformLibrary.Data
{
    public class SqlConnector : IDataConnection
    {
        const string CONNECTION_STRING = "EmployeeTrainingPlatform";
        public Department CreateDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        //TODO - Make the CreateEmployee method actually save to the database
        /// <summary>
        /// Saves a new employee to the database.
        /// </summary>
        /// <param name="employee">The employee information.</param>
        /// <returns>The employee information, including the unique identifier.</returns>
        public Employee CreateEmployee(Employee employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {


                var p = new DynamicParameters();
                p.Add("@name", employee.Department.ToString());
                int departmentId = 0;

                List<int> tmp_ids = connection.Query<int>("dbo.spDepartment_GetDepartmentId", p, commandType: CommandType.StoredProcedure).ToList();

                foreach (var id in tmp_ids)
                {
                    departmentId = id;
                    break;
                }

                p = new DynamicParameters();


                p.Add("@FirstName", employee.FirstName);
                p.Add("@LastName", employee.LastName);
                p.Add("@Department", departmentId);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spEmployee_Insert", p, commandType: CommandType.StoredProcedure);

                employee.Id = p.Get<int>("@id");

                return employee;

            }
        }

        /// <summary>
        /// Creates new employee and new user account with email and password
        /// </summary>
        /// <param name="employee">Object of an Employee</param>
        /// <param name="userCredentials">Object of an User Account</param>
        /// <returns>Created Employee</returns>
        public void CreateEmployeeUserAccount(Employee employee, UserAccountEntry userCredentials)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {
                // IDbTransaction transaction = connection.BeginTransaction();


                // ----------- Get Department Id -----------

                var p = new DynamicParameters();
                p.Add("@name", employee.Department.ToString());
                int departmentId = 0;

                List<int> tmp_ids = connection.Query<int>("dbo.spDepartment_GetDepartmentId", p, commandType: CommandType.StoredProcedure).ToList();

                foreach (var id in tmp_ids)
                {
                    departmentId = id;
                    break;
                }


                // ----------- Create Employee -----------
                p = new DynamicParameters();


                p.Add("@FirstName", employee.FirstName);
                p.Add("@LastName", employee.LastName);
                p.Add("@Department", departmentId);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spEmployee_Insert", p, commandType: CommandType.StoredProcedure);

                employee.Id = p.Get<int>("@id");


                // ----------- Create User Account -----------
                p = new DynamicParameters();


                p.Add("@EmployeeId", employee.Id);
                p.Add("@PasswordHash", userCredentials.PasswordHash);
                p.Add("@PasswordSalt", userCredentials.PasswordSalt);
                p.Add("@EmailAddress", userCredentials.EmailAddress);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spUserAccount_Insert", p, commandType: CommandType.StoredProcedure);

            }

        }

        /// <summary>
        /// Insert Training
        /// </summary>
        /// <param name="training">Training object</param>
        /// <returns></returns>
        public Training CreateTraining(Training training)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {
  

                var p = new DynamicParameters();
                p.Add("@Title", training.Title);
                p.Add("@Description", training.Description);
                p.Add("@Department", training.Department);
                p.Add("@Requirement", training.Requirement);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spTraining_Insert", p, commandType: CommandType.StoredProcedure);

                training.Id = p.Get<int>("@id");

                return training;

            }
        }

        /// <summary>
        /// Insert new booking entry
        /// </summary>
        /// <param name="employeeId">employee id of current employee</param>
        /// <param name="trainingId">training id of training</param>
        /// <param name="trainingStatus">training status of booking</param>
        public void CreateTrainingBooking(int employeeId, int trainingId, int trainingStatus)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                // ----------- Get Department Id -----------

                var p = new DynamicParameters();
                p.Add("@Training", trainingId);
                p.Add("@Employee", employeeId);
                p.Add("@TrainingStatus", trainingStatus);


                connection.Query<int>("dbo.spTrainingBooking_Insert", p, commandType: CommandType.StoredProcedure);

            }

        }

    
        public TrainingStatus CreateTrainingstatus(TrainingStatus training)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete training. 
        /// Contains: - delete all booking entries with training
        ///           - delete prerequisites entries
        ///           - delete training
        /// </summary>
        /// <param name="trainingId">Training Id</param>
        public void DeleteTraining(int trainingId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {
                var p = new DynamicParameters();
                p.Add("@Training", trainingId);

                //--------Delete booking entries--------

                connection.Execute("dbo.spTrainingBooking_DeleteEntry", p, commandType: CommandType.StoredProcedure);


                //--------Delete prerequisites entries--------

                p = new DynamicParameters();
                p.Add("@id", trainingId);
                connection.Execute("dbo.spTraining_DeletePrerequisite", p, commandType: CommandType.StoredProcedure);



                //--------Delete training --------

                p = new DynamicParameters();
                p.Add("@id", trainingId);
                connection.Execute("dbo.spTraining_Delete", p, commandType: CommandType.StoredProcedure);



            }
        }

        private void DeleteBookingEntries(DynamicParameters p, IDbConnection connection)
        {

        }

        /// <summary>
        /// Delete entry in training booking of given employee
        /// </summary>
        /// <param name="employeeId">Id of employee</param>
        /// <param name="trainingId">Id of training</param>
        public void DeleteTrainingBookingEntryOfEmployee(int employeeId, int trainingId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                var p = new DynamicParameters();
                p.Add("@Employee", employeeId);
                p.Add("@Training", trainingId);


                connection.Execute("dbo.spTrainingBooking_DeleteEntryOfEmployee", p, commandType: CommandType.StoredProcedure);


            }
        }

       

        /// <summary>
        /// Get every employee from dB
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAllEmployees()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {



                List<Employee> employees = connection.Query<Employee>("dbo.spEmployee_GetAll", commandType: CommandType.StoredProcedure).ToList();

                return employees;

            }
        }
        /// <summary>
        /// Get all booking entries of certain training with status booked
        /// </summary>
        /// <param name="trainingId">Id of training</param>
        /// <returns></returns>
        public List<TrainingBookingEntry> GetBookingsWithStatus(int trainingId, int trainingStatus)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                var p = new DynamicParameters();
                p.Add("@Training", trainingId);
                p.Add("@TrainingStatus",trainingStatus);

                List<TrainingBookingEntry> entries = connection.Query<TrainingBookingEntry>("dbo.spTrainingBooking_GetBookingsWStatus", p, commandType: CommandType.StoredProcedure).ToList();

                return entries;

            }
        }

        /// <summary>
        /// Gets all department names from the database
        /// </summary>
        /// <returns>All names of departments</returns>
        public List<string> GetDepartmentNames()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {


                List<string> departmentNames = connection.Query<string>("dbo.spDepartment_GetAllDepartmenNames", commandType: CommandType.StoredProcedure).ToList();

                return departmentNames;

            }
        }

        /// <summary>
        /// Get employee from dB by id
        /// </summary>
        /// <param name="id">Id of employee in dB</param>
        /// <returns>employee object</returns>
        public Employee GetEmployeeById(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                var p = new DynamicParameters();
                p.Add("@id", id);

                // ----------- Get Employee  -----------

                //Get Employee  from dB
                List<Employee> tmp_employee = connection.Query<Employee>("dbo.spEmployee_GetEmployeeById", p, commandType: CommandType.StoredProcedure).ToList();

                if (tmp_employee == null)
                {
                    throw new TrainingPlatformException("An error occured during the login process. Please contact an administrator.");
                }


                return tmp_employee[0];

            }
        }

        /// <summary>
        /// Get all training bookings of curren employee
        /// </summary>
        /// <param name="employeeId">Id of current employee</param>
        /// <returns>A list with all bookings of current employee</returns>
        public Dictionary<string, TrainingStatus> GetTrainingBooking(int employeeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                Dictionary<string, TrainingStatus> bookings = new Dictionary<string, TrainingStatus>();

                // ----------- Get all bookings  -----------


                var p = new DynamicParameters();
                p.Add("@Employee", employeeId);

                List<TrainingBookingEntry> trainings = connection.Query<TrainingBookingEntry>("dbo.spTrainingBooking_GetAllBookingsOfEmployee", p, commandType: CommandType.StoredProcedure).ToList();

                foreach (var tmp_entry in trainings)
                {
                    p = new DynamicParameters();
                    p.Add("@id", tmp_entry.Training);

                    List<Training> tmp_trainings = connection.Query<Training>("dbo.spTraining_GetById", p, commandType: CommandType.StoredProcedure).ToList();

                    if (tmp_trainings != null)
                    {
                        bookings.Add(tmp_trainings.First().Title, tmp_entry.TrainingStatus);
                    }

                }

                return bookings;

            }
        }

        //TODO TRAINING BY TITLE
        public Training GetTrainingById(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get all trainings
        /// </summary>
        /// <returns>All trainings</returns>
        public List<Training> GetTrainings()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                // ----------- Get Trainings  -----------


                List<Training> trainings = connection.Query<Training>("dbo.spTraining_GetAll", commandType: CommandType.StoredProcedure).ToList();


                return trainings;

            }
        }

        /// <summary>
        /// Get trainings which have given training as requirement
        /// </summary>
        /// <param name="requirement">Title of requirement</param>
        /// <returns>List with all trainings that have given training as requirement</returns>
        public List<Training> GetTrainingToRequirement(string requirement)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                var p = new DynamicParameters();
                p.Add("@Requirement", requirement);

                // ----------- Get Trainings  -----------


                List<Training> trainings = connection.Query<Training>("dbo.spTraining_GetTrainingToRequirement", p, commandType: CommandType.StoredProcedure).ToList();


                return trainings;

            }
        }





        /// <summary>
        /// Returns User Credentials such as passwordHash, passwordSalt and employee id of db entry
        /// </summary>
        /// <param name="emailAddress">Email Address of user that logs in</param>
        /// <returns></returns>
        public UserAccountEntry GetUserAccountCredentials(string emailAddress)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {
                UserAccountEntry userCredentials = new UserAccountEntry();

                var p = new DynamicParameters();
                p.Add("@EmailAddress", emailAddress);

                List<UserAccountEntry> tmp_userAccount = connection.Query<UserAccountEntry>("dbo.spUserAccount_GetUserCredentials", p, commandType: CommandType.StoredProcedure).ToList();

                if (tmp_userAccount.Count == 0)
                {
                    throw new TrainingPlatformException("No user account found with given email address and password.");
                }

                userCredentials = tmp_userAccount.First();

                return userCredentials;
            }

        }




        /// <summary>
        /// Get Employee Id of user which logs in
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUserAccountEmployeeId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update employee
        /// </summary>
        /// <param name="employee">Object of employeef </param>
        public void UpdateEmployee(Employee employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {
                // Get Department Id
                var p = new DynamicParameters();
                p.Add("@name", employee.Department.ToString());
                int departmentId = 0;

                List<int> tmp_ids = connection.Query<int>("dbo.spDepartment_GetDepartmentId", p, commandType: CommandType.StoredProcedure).ToList();

                foreach (var id in tmp_ids)
                {
                    departmentId = id;
                    break;
                }

                // Update Employee
                p = new DynamicParameters();
                p.Add("@LastName", employee.LastName);
                p.Add("@FirstName", employee.FirstName);
                p.Add("@Department", departmentId);
                p.Add("@id", employee.Id);


                connection.Execute("spEmployee_Update", p, commandType: CommandType.StoredProcedure);


            }
        }

        /// <summary>
        /// Update Training Status of booking entry
        /// </summary>
        /// <param name="employeeID">Id of employee</param>
        /// <param name="trainingStatus">Id of Training Status</param>
        public void UpdateTrainingBookingStatus(int employeeID, int trainingId, int trainingStatus)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {


                var p = new DynamicParameters();
                p.Add("@Employee", employeeID);
                p.Add("@TrainingStatus", trainingStatus);
                p.Add("@Training", trainingId);


                connection.Execute("dbo.spTrainingBooking_UpdateStatus", p, commandType: CommandType.StoredProcedure);


            }
        }

        /// <summary>
        /// Update User account
        /// </summary>
        /// <param name="userAccount">User Account Object</param>
        public void UpdateUserAccount(UserAccountEntry userAccount)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                var p = new DynamicParameters();
                p.Add("@EmailAddress", userAccount.EmailAddress);
                p.Add("@EmployeeId", userAccount.EmployeeId);
                p.Add("@PasswordSalt", userAccount.PasswordSalt);
                p.Add("@PasswordHash", userAccount.PasswordHash);


                connection.Execute("dbo.spUserAccount_Update", p, commandType: CommandType.StoredProcedure);


            }
        }

        /// <summary>
        /// Update role of employee
        /// </summary>
        /// <param name="employeeId">Employeee Id</param>
        /// <param name="roleId">Role Id</param>
        public void UpdateEmployeeRole(int employeeId, int roleId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                var p = new DynamicParameters();
                p.Add("@Role", roleId);
                p.Add("@id", employeeId);
             


                connection.Execute("dbo.spEmployee_UpdateRole", p, commandType: CommandType.StoredProcedure);


            }
        }

        /// <summary>
        /// Get all role names
        /// </summary>
        /// <returns>List with role names</returns>
        public List<Role> GetAllRoleNames()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                List<Role> roles = new List<Role>();

              
                    List<string> roleNames = connection.Query<string>("dbo.spRole_GetAllNames", commandType: CommandType.StoredProcedure).ToList();


                foreach (var name in roleNames)
                {
                    if (name.Equals(Role.ROLE_ADMIN.ToString()))
                    {
                        roles.Add(Role.ROLE_ADMIN);
                    }
                    if (name.Equals(Role.ROLE_EMPLOYEE.ToString()))
                    {
                        roles.Add(Role.ROLE_EMPLOYEE);
                    }
                }

                return roles;

            }
        }


        /// <summary>
        /// Get permission out of permission assignment where employe id is the same as in assignment entry
        /// </summary>
        /// <param name="employeeId">Id of employee</param>
        /// <param name="permissionId">Id of permission</param>
        /// <returns></returns>
        public Permission GetRolePermissionById(int roleId, int permissionId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            { 

                string permissionName = "";
                

                var p = new DynamicParameters();
                p.Add("RoleId", roleId);
                p.Add("@PermissionId", permissionId);


                List<string> permissions = connection.Query<string>("dbo.spRolePermission_GetPermission", p, commandType: CommandType.StoredProcedure).ToList();

                if(permissions.Count > 0)

                    permissionName = permissions.First();

                foreach (Permission tmp_permission in Enum.GetValues(typeof(Permission)))
                {
                    if (tmp_permission.ToString().Equals(permissionName))
                    {
                        return tmp_permission;
                    }
                }

                    return Permission.NO_PERMISSION;




            }
        }

        /// <summary>
        /// Update training
        /// </summary>
        /// <param name="training">Training object with new info</param>
        public void UpdateTraining(Training training)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                var p = new DynamicParameters();
                p.Add("@id", training.Id);
                p.Add("@Title", training.Title);
                p.Add("@Department", (int)training.Department);
                p.Add("@Description", training.Description);
                p.Add("@Requirement", training.Requirement);




                connection.Execute("dbo.spTraining_Update", p, commandType: CommandType.StoredProcedure);


            }
        }

        /// <summary>
        /// Get role of employee
        /// </summary>
        /// <param name="employeeId">Employee Id</param>
        /// <returns>Role of employee</returns>
        public Role GetEmployeeRole(int employeeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {
        
                string roleName = "";


                var p = new DynamicParameters();

                p.Add("id", employeeId);
    


                List<string> roles = connection.Query<string>("dbo.spEmployee_GetRole", p, commandType: CommandType.StoredProcedure).ToList();

                if (roles.Count > 0)

                    roleName = roles.First();

                foreach (Role tmp_role in Enum.GetValues(typeof(Role)))
                {
                    if (tmp_role.ToString().Equals(roleName))
                    {
                        return tmp_role;
                    }
                }

                return Role.NO_ROLE; ;




            }
        }

        /// <summary>
        /// Update email address of user account
        /// </summary>
        /// <param name="emailAddress">new email address</param>
        /// <param name="employeeId">employee id</param>
        void IDataConnection.UpdateUserAccountEmailAddress(string emailAddress, int employeeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                var p = new DynamicParameters();
                p.Add("@EmployeeId", employeeId);
                p.Add("@EmailAddress", emailAddress);


                connection.Execute("dbo.spUserAccount_UpdateEmailAddress", p, commandType: CommandType.StoredProcedure);


            }
        }

        /// <summary>
        /// Update password of user account
        /// </summary>
        /// <param name="userAccount">object which contains new password</param>
        void IDataConnection.UpdateUserAccountPassword(UserAccountEntry userAccount)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(CONNECTION_STRING)))
            {

                var p = new DynamicParameters();
                p.Add("@EmployeeId", userAccount.EmployeeId);
                p.Add("@PasswordSalt", userAccount.PasswordSalt);
                p.Add("@PasswordHash", userAccount.PasswordHash);


                connection.Execute("dbo.spUserAccount_UpdatePassword", p, commandType: CommandType.StoredProcedure);


            }
        }
    }
}
