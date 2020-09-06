using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Logic.General;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Printing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeeTrainingPlatformUI.Admin_Forms
{
    public partial class AdminEditTrainingPlanViewerForm : Form
    {
        const string ENTRY_NOTE = "Here the training plans of the employees can be edited. You are able to set a training to completed a training. \n Please use the search to select a user.";
        const string NO_TRAININGPLAN = "No bookings for";
        const string TRAININGPLAN = "Training plan of";

        public int EmployeeId = 0;
        public string EmployeeName = "";

        GeneralUILogic uILogic = new GeneralUILogic();
        GeneralTrainingLogic trainingLogic = new GeneralTrainingLogic();
        GeneralTrainingBookingLogic trainingBookingLogic = new GeneralTrainingBookingLogic();
        GeneralPermissionLogic permissionLogic = new GeneralPermissionLogic();
        

        public AdminEditTrainingPlanViewerForm()
        {
            InitializeComponent();
            InitForm();

        }

        private void InitForm()
        {

            
            textBoxNote.Text = ENTRY_NOTE;

            //Init user search
            uILogic.InitSelectUserGrid(searchUserControl1.SelectUser);

            uILogic.UpdateUserSearchResult(
                searchUserControl1.SelectUser, 
                searchUserControl1.Fullname.Text, 
                searchUserControl1.Department.Text,
                true);

            //Init department dropdown
            uILogic.PopulateDepartmentDropdown(searchUserControl1.Department);


            //assign EventHandler
            searchUserControl1.NameChanged += new EventHandler(UserControl_NameChanged);
            searchUserControl1.UserSelected += new DataGridViewCellEventHandler(UserControl_UserSelected);
            searchUserControl1.DepartmentChanged += new EventHandler(UserControl_DepartmentChanged);



            //init training plan of user

            InitUserOverviewGrid();
      
            setVisibilityTableHeader(false, false, "");
        }

        /// <summary>
        /// Initialize columns of grid (including clear all rows and columns first)
        /// </summary>
        private void InitUserOverviewGrid()
        {
            gridUserOverview.Rows.Clear();
            gridUserOverview.Columns.Clear();

         

            uILogic.AddTextBoxColumnToGrid(
                gridUserOverview,
                "cTraining",
                "Taining",
                0);

            uILogic.AddTextBoxColumnToGrid(
              gridUserOverview,
              "cDepartment",
              "Department",
              1);

            uILogic.AddTextBoxColumnToGrid(
              gridUserOverview,
              "cTrainingStatus",
              "Training Status",
              2);


            uILogic.AddButtonColumnToGrid(
                gridUserOverview,
                "btnStart",
                "",
                "Set to completed",
                3,
                Permission.PERM_COMPLETE_TRAINING);

        }

        private void PopulateTrainingPlan(int employeeId)
        {
            //get training plan of selected user
            Dictionary<string, TrainingStatus> trainingplan = trainingBookingLogic.GetTrainingBookingById(employeeId);

            //init columns of grid
            InitUserOverviewGrid();

            //check if there are bookings. if not, show a message and return
            if(trainingplan.Count == 0)
            {
                setVisibilityTableHeader(true, false, NO_TRAININGPLAN);
                return;
            }

            //Add a row with information for every training plan entry
            foreach (var entry in trainingplan)
            {
                string tmp_department = trainingLogic.GetDepartmentOfTraining(entry.Key);
                string[] tmp_row = new string[] { entry.Key, tmp_department , entry.Value.ToString()};
                gridUserOverview.Rows.Add(tmp_row);

            }


            //Set visibility of Set to complet button
            for (int i = 0; i < gridUserOverview.Rows.Count; i++)
            {
                string tmp_status = Regex.Replace(gridUserOverview.Rows[i].Cells[2].Value.ToString(), @"\s+", "");

                //check if training status is not in process and assign empty text cell if true
                if (!tmp_status.Equals(TrainingStatus.InProcess.ToString()))
                {
                    DataGridViewTextBoxCell emptyCell = new DataGridViewTextBoxCell();
                    emptyCell.Value = "";

                    gridUserOverview.Rows[i].Cells[3] = emptyCell;
                    emptyCell.ReadOnly = true;
                }

            }

            uILogic.SetLayoutOfGrid(gridUserOverview);

    
            setVisibilityTableHeader(true, true,TRAININGPLAN);


        }

        /// <summary>
        /// Set visibility of labels of table
        /// </summary>
        /// <param name="labelsVisibile"> determines, if label is visible</param>
        /// <param name="gridVisible"> determines if gris is visible</param>
        /// <param name="textValue">determnise text value</param>
        private void setVisibilityTableHeader(bool labelsVisibile, bool gridVisible, string textValue)
        {
            showNameLabel.Visible = labelsVisibile;
            showNameLabel.Text = EmployeeName;

            overviewHeaderLabel.Visible = labelsVisibile;
            overviewHeaderLabel.Text = textValue;

            gridUserOverview.Visible = gridVisible;
        }
        
        protected void UserControl_UserSelected(object sender, DataGridViewCellEventArgs e)
        {
            if (permissionLogic.HasUserPermission(Permission.PERM_OPEN_USER_DETAILS))
            {

                //Event -> Select User
                if (e.ColumnIndex == 3)
                {
                    //Get user id from grid cell
                    string employeeIdString = searchUserControl1.SelectUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                    try
                    {
                        EmployeeId = int.Parse(employeeIdString);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured while loading the employee data. Please try again or contact an administrator.");
                        Debug.Write($"Error during parsing employee id ({employeeIdString}) to int. Error Message: {ex.Message}");
                        return;
                    }

                    try
                    {
                        //save employee name
                        EmployeeName = searchUserControl1.SelectUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                        PopulateTrainingPlan(EmployeeId);

                    }
                    catch (NoPermissionException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured while loading the employee data. Please try again or contact an administrator.");
                        Debug.Write($"Error during populating training plan grid. Error Message: {ex.Message}");
                        return;
                    }


                }
            }
            else
            {
                MessageBox.Show("You do not have the permission to open user details.");
            }
        }

 

        protected void UserControl_NameChanged(object sender, EventArgs e)
        {

            uILogic.InitSelectUserGrid(searchUserControl1.SelectUser);
            uILogic.UpdateUserSearchResult(
                searchUserControl1.SelectUser, 
                searchUserControl1.Fullname.Text, 
                searchUserControl1.Department.Text,
                false);

        }

        protected void UserControl_DepartmentChanged(object sender, EventArgs e)
        {
           
                uILogic.InitSelectUserGrid(searchUserControl1.SelectUser);
            uILogic.UpdateUserSearchResult(
               searchUserControl1.SelectUser,
               searchUserControl1.Fullname.Text,
               searchUserControl1.Department.Text,
               false);



        }

        private void gridUserOverview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //determine if clicked cell is a complete training button or not
            bool isButton = (!gridUserOverview.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("")) && !(gridUserOverview.Rows[e.RowIndex].Cells[3].Value.ToString() == null);

            //Event -> Complete Training
            if (e.ColumnIndex == 3 && isButton)
            {
                //show dialog
                if (uILogic.ValidateUserEntry(
                   "Are you sure you want to set the training '" + gridUserOverview.Rows[e.RowIndex].Cells[0].Value.ToString() + "' to completed ?",
                   "Complete Training")
               )
                {
                    trainingBookingLogic.UpdateTrainingStatus(EmployeeId, gridUserOverview.Rows[e.RowIndex].Cells[0].Value.ToString(), TrainingStatus.Completed, true);
                    InitUserOverviewGrid();
                    PopulateTrainingPlan(EmployeeId);
                }
            }
        }
    }

  
}
