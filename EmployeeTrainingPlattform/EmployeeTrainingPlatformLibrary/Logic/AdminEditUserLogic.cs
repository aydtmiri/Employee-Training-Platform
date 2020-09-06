using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Logic.General
{
    public class AdminEditUserLogic
    {
        public IDataConnection db;
        private GeneralPermissionLogic permissionLogic = new GeneralPermissionLogic();
        private GeneralEmployeeLogic employeeLogic = new GeneralEmployeeLogic();
        
        public AdminEditUserLogic()
        {
            db = GlobalConfig.Connection;
        }

        public AdminEditUserLogic(IDataConnection connection)
        {
            db = connection;
        }
        /// <summary>
        /// Assign role admin to employee
        /// Containing: - assign role admin
        ///             - assign admin related permissions
        /// </summary>
        /// <param name="employeeId">Id of employee</param>
        public void AssignAdminRole(int employeeId)
        {
            //get employee by id
            Employee employee = employeeLogic.GetEmployeeById(employeeId);

            if(employee == null)
            {
                Debug.WriteLine($"ERROR during AssignAdminRole : No employee with id {employee} found.");
                throw new Exception();
            }
            //call database logic
            db.UpdateEmployeeRole(employeeId, (int)Role.ROLE_ADMIN);

            Employee.Employees = db.GetAllEmployees();

        

        }

       





    }
}
