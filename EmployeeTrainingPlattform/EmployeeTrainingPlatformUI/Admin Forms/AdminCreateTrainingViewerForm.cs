using System;
using EmployeeTrainingPlatformLibrary.Logic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Converters;
using EmployeeTrainingPlatformLibrary.Model;
using System.Diagnostics;

namespace EmployeeTrainingPlatformUI
{
    public partial class AdminCreateTrainingViewerForm : Form
    {
        GeneralUILogic uiLogic = new GeneralUILogic();
        AdminCreateTrainingLogic logic = new AdminCreateTrainingLogic();


        public AdminCreateTrainingViewerForm()
        {
            InitializeComponent();
            InitForm();
           
        }

        private string ValidateForm()
        {
            StringBuilder errorMessage = new StringBuilder();

            if(inputTitle.Text.Length == 0)
            {
                errorMessage.Append("Please provide a title. \n");
            }

            if (inputDepartment.Text.Equals("Select department"))
            {
                errorMessage.Append("Please choose a department. \n");
            }

            if(inputDescription.Text.Length == 0)
            {
                errorMessage.Append("Please provide a description.\n");
            }

            return errorMessage.ToString();
        }

        private void InitForm()
        {

            uiLogic.PopulateDepartmentDropdown(inputDepartment);

            //prefill requirement search result with all available trainings
            uiLogic.UpdateTrainingSearchResult(
                outputRequirementResult, 
                inputRequirement.Text, 
                inputDepartment.Text, 
                true);

            //set char counter to 0
            charCounterLabel.Text = (inputDescription.Text.Length).ToString();

        }

        private void btnCreateTraining_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateForm();

            //check if there are errors. If not call logic to create training. else show the error message
            if(errorMessage.Length == 0)
            {
                try
                {
                    //call logic to create training
                    logic.CreateTraining(
                        inputTitle.Text,
                        inputDepartment.Text,
                        inputRequirement.Text,
                        inputDescription.Text
                        );

                  
                }
                catch(NoPermissionException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (TrainingPlatformException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"ERROR during training creation. Error Message: {ex.Message}");
                    MessageBox.Show("An error occured while booking the training. Please try again or contact an administrator");
                    return;
                }

                MessageBox.Show($"Successfully created training with title '{inputTitle.Text}'.");
                ResetForm();
            }
            else
            {
                MessageBox.Show(errorMessage);

               
            }
        }

        /// <summary>
        /// delete all user inputs
        /// </summary>
        private void ResetForm()
        {
            inputTitle.Text = "";
            uiLogic.PopulateDepartmentDropdown(inputDepartment);
            inputRequirement.Text = "";
            inputDescription.Text = "";
        }
        private void inputRequirement_TextChanged(object sender, EventArgs e)
        {
            //update search result
            uiLogic.UpdateTrainingSearchResult(
                outputRequirementResult,
                inputRequirement.Text,
                inputDepartment.Text,
                true);
        }

        private void inputDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update search result
            uiLogic.UpdateTrainingSearchResult(
                outputRequirementResult,
                inputRequirement.Text,
                inputDepartment.Text,
                true);
        }

        private void outputReequirementResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show selected requirement in input field for requirement
            inputRequirement.Text = outputRequirementResult.SelectedItem.ToString();
        }

        private void inputDescription_TextChanged(object sender, EventArgs e)
        {
            //increase/decrease character counter
            charCounterLabel.Text = (inputDescription.Text.Length).ToString();
        }
    }
}
