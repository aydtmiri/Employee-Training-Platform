using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeTrainingPlatformUI.Admin_Forms
{
    public partial class AdminEditTrainingWindowForm : Form
    {
        public string Title { get; set; }

        GeneralUILogic uILogic = new GeneralUILogic();
        GeneralTrainingLogic trainingLogic = new GeneralTrainingLogic();
        AdminEditTrainingLogic logic = new AdminEditTrainingLogic();


        public AdminEditTrainingWindowForm(string title)
        {
            Title = title;

            InitializeComponent();
            InitForm();
        }

        /// <summary>
        /// Initialize form
        /// Contains:   - Populate department dropdown
        ///             - Prefill textfields
        ///             - Prefill search results
        /// </summary>
        private void InitForm()
        {
            //Populate department dropdown
            uILogic.PopulateDepartmentDropdown(inputDepartment);

            //prefill fields
            Training training = trainingLogic.GetSelectedTraining(Title);

            if(training == null)
            {
                Debug.WriteLine($"Error during fetching training: No training with title {Title}");
                MessageBox.Show("An error occured while loading the training. Please try again.");
                this.Close();
            }

            inputTitle.Text = training.Title;
            inputDepartment.SelectedIndex = inputDepartment.FindString(training.Department.ToString());
            inputPrerequisite.Text = training.Requirement;
            inputDescription.Text = training.Description;

            //prefill prerequisite earch output
            PopulatePrerequisiteSearchResult();


        }

        /// <summary>
        /// Populate prerequisite search results.
        /// remove current title and all trainings that have current training as prerequisite from output
        /// </summary>
        private void PopulatePrerequisiteSearchResult()
        {
            //prefill prerequisite earch output
            uILogic.UpdateTrainingSearchResult(
                outputPrerequisite,
                inputPrerequisite.Text,
                inputDepartment.Text,
                true);

            //remove current training from training list
            if (outputPrerequisite.Items.Contains(Title))
            {
                outputPrerequisite.Items.Remove(Title);
            }

            //get all trainings, that have current training as prerequisite
            List<Training> trainings = trainingLogic.GetTrainingToRequirement(Title);

            //remove all trainings, that have current training as prerequisite
            foreach (var tmp_training in trainings)
            {
                if (outputPrerequisite.Items.Contains(tmp_training.Title))
                {
                    outputPrerequisite.Items.Remove(tmp_training.Title);
                }
            }
        }

        private void inputDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePrerequisiteSearchResult();
        }

        private void inputPrerequisite_TextChanged(object sender, EventArgs e)
        {
            PopulatePrerequisiteSearchResult();
        }

        private void btnUpdateTraining_Click(object sender, EventArgs e)
        {
            try
            {
                logic.UpdateTraining(
                        Title,
                        inputTitle.Text,
                        inputDepartment.Text,
                        inputPrerequisite.Text,
                        inputDescription.Text);
            }
            catch(NoPermissionException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(TrainingPlatformException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while saving the training data. Please try again or contact an administrator.");
                Debug.Write($"Error during populating updating training with title '{Title}'. Error Message: {ex.Message}");
                return;
            }

            MessageBox.Show("Successfully updated training.");
            this.Close();
        }

        private void outputPrerequisite_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set input field of prerequisite to selected prerequisite
            inputPrerequisite.Text = outputPrerequisite.SelectedItem.ToString();
        }
    }
}
