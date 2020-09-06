
using EmployeeTrainingPlatformLibrary.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeTrainingPlatformUI
{
    public partial class EmployeeCreateAccountViewerForm : Form
    {
        GeneralUILogic uiLogic = new GeneralUILogic();
        CreateAccountLogic logic = new CreateAccountLogic();

        public EmployeeCreateAccountViewerForm()
        {
            InitializeComponent();
            uiLogic.PopulateDepartmentDropdown(inputDepartment);
        }

        /// <summary>
        /// Validate if all mandatory fields are filled
        /// </summary>
        /// <returns>error message</returns>
        private string ValidateForm()
        {
            StringBuilder output = new StringBuilder();

            if(inputFirstName.TextLength == 0)
            {
                output.Append("Please enter a first name.\n");
                  
            }

            if(inputLastName.TextLength == 0)
            {
                output.Append("Please enter a last name.\n");
            }

            if(inputDepartment.Text.Equals("Select department"))
            {
                output.Append("Please select a department.\n");
            }

            if (inputEmailAddress.TextLength == 0)
            {
                output.Append("Please enter an email address.\n");
            }
            else
            {
                try
                {
                    new System.Net.Mail.MailAddress(inputEmailAddress.Text);
                }
                catch (Exception)
                {
                    output.Append("The given email address has an invalid format.\n");
                }
            }

            if (inputPassword.TextLength == 0)
            {
                output.Append("Please enter a password.");
            }
            else
            {
                if(inputPassword.TextLength < 6)
                {
                    output.Append("The password has to be at least 6 characters long.");
                }
            }



            return output.ToString();
        }

        private void inputFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateForm();

            if(errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                try
                {
                    logic.CreateEmployee(
                                inputFirstName.Text,
                                inputLastName.Text,
                                inputDepartment.Text,
                                inputEmailAddress.Text,
                                inputPassword.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured while creating an account. Please try again or contact an administrator");
                    Debug.WriteLine($"An error occured while creating the user account.Error: {ex.Message}");
                    return;
                }

                MessageBox.Show("Successfully created a user account. You can now log in.");
                this.Close();
            }


        }
    }
}
