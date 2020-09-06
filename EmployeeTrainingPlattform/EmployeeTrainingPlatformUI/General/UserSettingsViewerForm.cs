
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Logic.General;
using EmployeeTrainingPlatformLibrary.Model;

namespace EmployeeTrainingPlatformUI
{
    public partial class UserSettingsViewerForm : Form

    {

        private UserSettingsLogic logic= new UserSettingsLogic();
        private GeneralDepartmentLogic departmentLogic = new GeneralDepartmentLogic();
        private GeneralEmployeeLogic employeeLogic = new GeneralEmployeeLogic();
        private GeneralUILogic uiLogic = new GeneralUILogic();
        private GeneralPermissionLogic permissionLogic = new GeneralPermissionLogic();

        public UserSettingsViewerForm()
        {
            InitializeComponent();
            InitForm();
            
        }

        /// <summary>
        /// Initialize form
        /// Including:  - Populate dropdown
        ///             - set visibility of button
        ///             - prefill fields
        /// </summary>
        private void InitForm()
        {
            //Init department dropdown
            uiLogic.PopulateDepartmentDropdown(inputDepartment);

            //set visibility of button according to permission of current user
            btnSave.Enabled = permissionLogic.HasUserPermission(Permission.PERM_UPDATE_SETTINGS);

            PrefillFields();
        }

        /// <summary>
        /// Prefill values with the information of current user
        /// </summary>
        private void PrefillFields()
        {
            inputFirstName.Text = Global.employee.FirstName;
            inputLastName.Text = Global.employee.LastName;
            inputDepartment.SelectedIndex = inputDepartment.FindString(Global.employee.Department.ToString());
            changeUserCredentials1.EmailAddress.Text = Global.employee.EmailAddress;

        }

        /// <summary>
        /// Validates user input
        /// </summary>
        /// <returns>Error message</returns>
        private string ValidateForm()
        {
            StringBuilder output = new StringBuilder();

            //check if a department is selected
            if (inputDepartment.Text.Length.Equals("Select department"))
            {
                output.Append("Please select a department.\n");
            }

            //check if email has right format
            if (changeUserCredentials1.EmailAddress.Text.Length > 0)
            {

                try
                {
                    new System.Net.Mail.MailAddress(changeUserCredentials1.EmailAddress.Text);
                }
                catch (Exception)
                {
                    output.Append("The given email address has an invalid format.\n");
                }
            }

            if (changeUserCredentials1.NewPassword.Text.Length > 0 || changeUserCredentials1.CurrentPassword.Text.Length > 0)
            {


                //check if an old password was entered but no new password
                if (changeUserCredentials1.NewPassword.Text.Length == 0 && changeUserCredentials1.CurrentPassword.Text.Length > 0)
                {
                    output.Append("Please enter a new password. If you do not want to change your password, please withdraw the current password entry. ");
                }
                else
                {
                    //check if new password was entered but no old password
                    if (changeUserCredentials1.NewPassword.Text.Length > 0 && changeUserCredentials1.CurrentPassword.Text.Length == 0)
                    {
                        output.Append("In order to change your password, please enter your current password");
                    }
                    else

                //check if password is at least 6 characters long
                if (changeUserCredentials1.NewPassword.Text.Length < 6)
                    {
                        output.Append("The password has to be at least 6 characters long.");
                    }
                }
            }

            return output.ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateForm();

            //check if there are error. if not, proceed with logic
            if (errorMessage.Length == 0)
            {

                try
                {
                    logic.ChangeUserSettings(
                              inputFirstName.Text,
                              inputLastName.Text,
                              inputDepartment.Text,
                              changeUserCredentials1.EmailAddress.Text,
                              changeUserCredentials1.CurrentPassword.Text,
                              changeUserCredentials1.NewPassword.Text);

                    MessageBox.Show("Successfully updated user account.");

                    changeUserCredentials1.CurrentPassword.Text = "";
                    changeUserCredentials1.NewPassword.Text = "";


                }


                catch(TrainingPlatformException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show("An error occured while booking the training. Please try again or contact an administrator");
                    return;
                }
            }
            else
            {
                MessageBox.Show(errorMessage);
            }

        }
    }
}



