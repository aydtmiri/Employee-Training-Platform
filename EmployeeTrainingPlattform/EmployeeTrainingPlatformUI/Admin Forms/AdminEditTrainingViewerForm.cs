using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Logic.General;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlatformUI.Admin_Forms;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeeTrainingPlatformUI
{
    public partial class AdminEditTrainingViewerForm : Form
    {
        GeneralUILogic uiLogic = new GeneralUILogic();
        GeneralTrainingLogic trainingLogic = new GeneralTrainingLogic();
        AdminEditTrainingLogic logic = new AdminEditTrainingLogic();
        GeneralPermissionLogic permissionLogic = new GeneralPermissionLogic();

        const string ENTRY_TEXT = "Here you are able to delete or edit exisiting trainings.\n Please use the search to search for the required training. ";
        public AdminEditTrainingViewerForm()
        {
            InitializeComponent();

            InitForm();
        }

        /// <summary>
        /// Initialize form.
        /// Containing: - Populate department dropdown
        ///             - set entry text
        ///             - iitilaize grid
        /// </summary>
        public void InitForm()
        {
            //populate department dropdown
            uiLogic.PopulateDepartmentDropdown(inputDepartment);

            //init entry text
            entryTextLabel.Text = ENTRY_TEXT;

            //init grid
            InitGrid();
        }

        /// <summary>
        /// Initialize grid.
        /// Containing: - init columns
        ///             - populate grid
        ///             - set layout
        /// </summary>
        public void InitGrid()
        {
            InitColumnsOfGrid();
            PopulateTrainingResult();

            uiLogic.SetLayoutOfGrid(gridTrainingesult);
        }

        /// <summary>
        /// Populate grid with all existing trainings
        /// </summary>
        private void PopulateTrainingResult()
        {
            // Add booked tranings rows to grid
            foreach (var training in Training.Trainings)
            {
                string tmp_department = trainingLogic.GetDepartmentOfTraining(training.Title);

                //Add row  |Training Id | Title | Department|
                string[] tmp_row = new string[] { training.Id.ToString(), training.Title, tmp_department };
                gridTrainingesult.Rows.Add(tmp_row);

            }
        }

        /// <summary>
        /// Initialize columns of grid (including clear all rows and columns first)
        /// </summary>
        private void InitColumnsOfGrid()
        {
            gridTrainingesult.Rows.Clear();
            gridTrainingesult.Columns.Clear();


            uiLogic.AddTextBoxColumnToGrid(
                gridTrainingesult,
                "cTrainingId",
                "",
                0);

            gridTrainingesult.Columns[0].Visible = false;

            uiLogic.AddTextBoxColumnToGrid(
                gridTrainingesult,
                "cTraining",
                "Training",
                1);

            uiLogic.AddTextBoxColumnToGrid(
              gridTrainingesult,
              "cDepartment",
              "Department",
              2);


        uiLogic.AddButtonColumnToGrid(
            gridTrainingesult,
            "btnEdit",
            "",
            "Edit",
            3,
            Permission.PERM_EDIT_TRAINING);

        uiLogic.AddDeleteButtonColumnToGrid(
            gridTrainingesult,
            "btnDelete",
            "",
            "Delete",
            4,
            Permission.PERM_DELETE_TRAINING);
        }

        /// <summary>
        /// Update training grid according to search input
        /// </summary>
        public void UpdateTrainingGridSearchResult()
        {

            string department = inputDepartment.Text;
            string title = inputTitle.Text;

            //check if no department is selected. if so, set department null, so it isn't considered in the search
            if (inputDepartment.Text.Equals("Select department"))
            {
                department = null;
            }




            foreach (var training in Training.Trainings)
            {

                //scenario: department is selected and title is entered
                if (!string.IsNullOrEmpty(department) && !string.IsNullOrEmpty(title))
                {
                    // Add training if training relates to department and contains title
                    if (training.Department.ToString().Equals(Regex.Replace(department, @"\s+", "")) && training.Title.Contains(title))
                    {
                        AddRowToGrid(training);
                    }
                }
                else
                {

                    //scenario:  department is selected and title is empty
                    if (!string.IsNullOrEmpty(department) && string.IsNullOrEmpty(title))
                    {
                        //Add training is it relates to department
                        if (training.Department.ToString().Equals(Regex.Replace(department, @"\s+", "")))
                        {

                            AddRowToGrid(training);
                        }
                    }
                    else
                    {

                        //scenario: title is filled and department empty
                        if (string.IsNullOrEmpty(department) && !string.IsNullOrEmpty(title))
                        {
                            //Add training if it contains title

                            if (training.Title.Contains(title))
                            {
                                AddRowToGrid(training);
                            }

                        }
                        else
                        {
                            AddRowToGrid(training);
                        }
                    }
                }

            }
        }


        /// <summary>
        /// Add single row to grid, containing  |Training Id | Title | Department|
        /// </summary>
        /// <param name="training">object of training</param>
        private void AddRowToGrid(Training training)
        {
            //Add row  |Training Id | Title | Department|
            string[] tmp_row = new string[] { training.Id.ToString(), training.Title, training.Department.ToString() };
            gridTrainingesult.Rows.Add(tmp_row);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void inputTitle_TextChanged(object sender, EventArgs e)
        {
            //Updates gird search result when tilte of training changes
            InitColumnsOfGrid();
            UpdateTrainingGridSearchResult();
        }

        private void inputDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Updates gird search result when departmentchanges
            InitColumnsOfGrid();
            UpdateTrainingGridSearchResult();
        }

        private void HandleEventDeleteButtonClick(DataGridViewCellEventArgs e)
        {



            if (uiLogic.ValidateUserEntry(
                  "Are you sure you want delete the training '" + gridTrainingesult.Rows[e.RowIndex].Cells[1].Value.ToString() + "'?",
                  "Delete Training")
              )
            {

                int trainingId = 0;

                //Get training id from grid cell
                string trainingIdString = gridTrainingesult.Rows[e.RowIndex].Cells[0].Value.ToString();

                //Try to pars string id into int
                try
                {
                    trainingId = int.Parse(trainingIdString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured. Please try again or contact an administrator.");
                    Debug.WriteLine($"Error during parsing training id ({trainingIdString}) to int. Error Message: {ex.Message}");
                    return;
                }

                //Call logic for deletion of training
                try
                {
                    logic.DeleteTraining(trainingId);
                }
                catch (TrainingPlatformException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occured during deletion of training. Error: {ex.Message}.");
                    MessageBox.Show("An error occured while deleting the training. Please try again or contact an administrator");
                    return;
                }

                //Show succession message
                MessageBox.Show("Successfully deleted training.");

                //refresh grid
                InitGrid();
            }

        }

        private void HandleEventEditButtonClick(DataGridViewCellEventArgs e)
        {

            try
            {
                AdminEditTrainingWindowForm form = new AdminEditTrainingWindowForm(gridTrainingesult.Rows[e.RowIndex].Cells[1].Value.ToString());
                form.ShowDialog();
            }
            catch (Exception ex)
            {

                Debug.WriteLine($"An error occured. Error: {ex.Message}.");
                MessageBox.Show("An error occured while. Please try again or contact an administrator");
                return;
            }


        }

        private void gridTrainingesult_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Event -> Edit
            if (e.ColumnIndex == 3)
            {
                HandleEventEditButtonClick(e);

            }

            //Event -> Delete 
            if (e.ColumnIndex == 4)
            {
                HandleEventDeleteButtonClick(e);

            }
        }
    }
}
