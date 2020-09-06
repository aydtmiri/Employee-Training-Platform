
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Logic
{
    public class LogoutLogic
    {
        public void Logout()
        {
            Global.employee = null;
            Training.Trainings = null;
            Employee.Employees = null;
        }
    }
}
