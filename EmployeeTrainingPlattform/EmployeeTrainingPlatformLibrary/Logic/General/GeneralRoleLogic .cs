using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Model;
using System.Collections.Generic;


namespace EmployeeTrainingPlatformLibrary.Logic
{
    public  class GeneralRoleLogic
    {

        public IDataConnection db;

        public GeneralRoleLogic()
        {
            db = GlobalConfig.Connection;
        }

        public GeneralRoleLogic(IDataConnection connection)
        {
            db = connection;
        }

        /// <summary>
        /// Returns all department names
        /// </summary>
        /// <returns>All departments names</returns>
        public List<Role> GetAllRoleNames()
        {

            return db.GetAllRoleNames();
        }

        public bool IsAdmin()
        {
            Role role = db.GetEmployeeRole(Global.employee.Id);

            if(role.Equals(Role.ROLE_ADMIN))
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

      

    }
}
