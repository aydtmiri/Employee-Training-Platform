using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Logic.General
{
    public class GeneralPermissionLogic
    {
        public IDataConnection db;

        public GeneralPermissionLogic()
        {
            db = GlobalConfig.Connection;
        }

        public GeneralPermissionLogic( IDataConnection connection)
        {
            db = connection;
        }

        /// <summary>
        /// Validates if user has a certain permission
        /// </summary>
        /// <param name="permission">Id of permission</param>
        /// <returns>true if user has permission, false if not</returns>
        public bool HasUserPermission(Permission permission)
        {
            Permission tmp_permission = db.GetRolePermissionById((int) Global.employee.Role, (int)permission);

            if(tmp_permission.Equals(permission))
            {
                return true;
            }

            return false;

        }

      
    }
}
