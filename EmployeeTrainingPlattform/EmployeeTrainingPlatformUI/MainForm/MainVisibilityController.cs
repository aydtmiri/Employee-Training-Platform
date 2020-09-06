using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace EmployeeTrainingPlatformUI.MainForm
{
    public class MainVisibilityController
    {
      
        /// <summary>
        /// Sets visibility according to Role of employee
        /// </summary>
        public void SetVisibility(MainViewerForm form)
        {
            //Check if employee has Role EMPLOYEE
            if(Global.employee.Role.Equals(Role.ROLE_EMPLOYEE))
            {
                //Menu "Employees" -> not visible
                form.MenuEmployee.Visible = false;
                form.SubMenuEditEmployee.Visible = false;

                //Menu "Training" -> Book Training | Training Plan
                form.MenuTraining.Visible = true;
                form.SubMenuBookTraining.Visible = true;
                form.SubMenuTrainingPlan.Visible = true;

                
                form.SubMenuEditTrainingPlan.Visible  = false;
                form.SubMenuEditTraining.Visible = false;
                form.SubMenuCreateTraining.Visible = false;

                //Menu "User Settings" -> visible
                form.MenuUser.Visible = true;
                form.SubMenuChangeUserSettings.Visible = true;




            }

            //Check if employee has Role ADMIN
            if (Global.employee.Role.Equals(Role.ROLE_ADMIN))
            {
                //Menu "Employees" -> visible
                form.MenuEmployee.Visible = true;
                form.SubMenuEditEmployee.Visible = true;

                //Menu "Training" -> Edit Training Plan | Create Training | Edit Training
                form.MenuTraining.Visible = true;
                form.SubMenuBookTraining.Visible = false;
                form.SubMenuTrainingPlan.Visible = false;

                form.SubMenuEditTrainingPlan.Visible = true;
                form.SubMenuEditTraining.Visible = true;
                form.SubMenuCreateTraining.Visible = true;

                //Menu "User Settings" -> visible
                form.MenuUser.Visible = true;
                form.SubMenuChangeUserSettings.Visible = true;
            }
        }
    }
}
