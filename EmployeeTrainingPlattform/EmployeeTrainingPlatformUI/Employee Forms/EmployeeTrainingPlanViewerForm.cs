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
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;

namespace EmployeeTrainingPlatformUI.Employee_Forms.EmployeeTrainingPlanViewerForm
{
    public partial class EmployeeTrainingPlanViewerForm : Form
    {

        const string ENTRY_TEXT = "Here all your booked trainings are listed.\n You can start a training by pressing the 'Start Training' button. Or you can delete a booking entry by pressing the 'Delete booking' button. \n To see more details about a certain training, please double click on the title.";
        const string NO_BOOKINGS_TEXT = "You do not have any bookings yet. To book a training, please go to the 'Book Training' tab.";

        GeneralTrainingBookingLogic bookingLogic = new GeneralTrainingBookingLogic();
        GeneralTrainingLogic trainingLogic = new GeneralTrainingLogic();
        GeneralPermissionLogic permissionLogic = new GeneralPermissionLogic();
        GeneralUILogic uILogic = new GeneralUILogic();


        public EmployeeTrainingPlanViewerForm()
        {
            InitializeComponent();
            InitializeForm();

        }


        /// <summary>
        /// Initialize form
        /// Includes:   - get training plan
        ///             - init trainingplan grid
        /// </summary>
        private void InitializeForm()
        {
            //Get trainingplan of current user
            Dictionary<string, string> trainingplan = bookingLogic.GetTrainingBooking();

            //check if there are any booked trainings. if so, show them.
            if (trainingplan.Count > 0)
            {
                textBoxNote.Text = ENTRY_TEXT;
                InitTtrainingPlanGrid();
                PopulateTrainingPlan(trainingplan);

            }
            else
            {
                textBoxNote.Text = NO_BOOKINGS_TEXT;
                gridTrainingPlan.Visible = false;
            }

            //set visibility of grid false
            trainingOverviewUserControl.Visible = false;

        }
        /// <summary>
        /// Initialize columns of grid (including clear all rows and columns first)
        /// </summary>
        private void InitTtrainingPlanGrid()
        {
            gridTrainingPlan.Rows.Clear();
            gridTrainingPlan.Columns.Clear();


            uILogic.AddTextBoxColumnToGrid(
                gridTrainingPlan,
                "cTraining",
                "Taining",
                0);

            uILogic.AddTextBoxColumnToGrid(
              gridTrainingPlan,
              "cDepartment",
              "Department",
              1);

            uILogic.AddTextBoxColumnToGrid(
              gridTrainingPlan,
              "cTrainingStatus",
              "Training Status",
              2);


            uILogic.AddDeleteButtonColumnToGrid(
                gridTrainingPlan,
                "btnDelete",
                "",
                "Delete Booking",
                3,
                Permission.PERM_DELETE_BOOKING_ENTRY);

            

            uILogic.AddButtonColumnToGrid(
                gridTrainingPlan,
                "btnStart",
                "",
                "Start Training",
                4,
                Permission.PERM_START_TRAINING);

          
        }

        private void PopulateTrainingPlan(Dictionary<string, string> trainingplan)
        {
            // Add booked tranings rows to grid
            foreach (var entry in trainingplan)
            {
                string tmp_department = trainingLogic.GetDepartmentOfTraining(entry.Key);
                string[] tmp_row = new string[] { entry.Key, tmp_department, entry.Value };
                gridTrainingPlan.Rows.Add(tmp_row);

            }


            // Set "visibility" of button to start training 
            for (int i = 0; i < gridTrainingPlan.Rows.Count; i++)

            {
                //-------- Start Training Button --------
                string tmp_status = gridTrainingPlan.Rows[i].Cells[2].Value.ToString();


                //TODO Es ist hier copleted aber trotzdezeichnet esbutton 
                //If status of training isn't booked, add an empty cell instead of an start training button
                if (!tmp_status.Equals(TrainingStatus.Booked.ToString()))
                {
                    //make current cell an empty cell

                    DataGridViewTextBoxCell emptyCell = new DataGridViewTextBoxCell();
                    emptyCell.Value = "";
                    gridTrainingPlan.Rows[i].Cells[4] = emptyCell;
                    emptyCell.ReadOnly = true;
                }

            }

            uILogic.SetLayoutOfGrid(gridTrainingPlan);

        }

    

        private void searchTrainingUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void headlineTrainingPlan_Click(object sender, EventArgs e)
        {

        }

        private void gridTrainingPlan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if an item in the column "Training" is selected, show it's details in the overview panel
            if (e.ColumnIndex == 0)
            {

                uILogic.showSelectedTraining(
                    gridTrainingPlan.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    trainingOverviewUserControl.Title,
                    trainingOverviewUserControl.Department,
                    trainingOverviewUserControl.Requiremnt,
                    trainingOverviewUserControl.Description);

                trainingOverviewUserControl.Visible = true;

            }

        }

        private void DeleteBooking_CellClick(DataGridViewCellEventArgs e)
        {
            //show dialog 
            if (uILogic.ValidateUserEntry(
                "Are you sure you want to delete the booking entry for  training '" + gridTrainingPlan.Rows[e.RowIndex].Cells[0].Value.ToString() + "'?",
                "Delete Training Entry")
            )
            {

                try
                {
                    bookingLogic.DeleteBookingEntry(gridTrainingPlan.Rows[e.RowIndex].Cells[0].Value.ToString());
                    InitializeForm();

                }
                catch (TrainingPlatformException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    Debug.Fail($"ERROR during Click Event on Delete Booking button: {ex.Message}");
                    MessageBox.Show("An error occured while deleting the booking entry. Please try again or contact an administrator");


                }
            }
        }

        private void StartTraining_CellClick(DataGridViewCellEventArgs e)
        {
            if (uILogic.ValidateUserEntry(
                 "Are you sure you want start with the training '" + gridTrainingPlan.Rows[e.RowIndex].Cells[0].Value.ToString() + "'?",
                 "Start Training"))
            {

                try
                {
                    bookingLogic.UpdateTrainingStatus(Global.employee.Id, gridTrainingPlan.Rows[e.RowIndex].Cells[0].Value.ToString(), TrainingStatus.InProcess, false);
                    InitializeForm();

                }
                catch (TrainingPlatformException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    Debug.Fail($"ERROR during Click Event on Delete Booking button: {ex.Message}");
                    MessageBox.Show("An error occured while deleting the booking entry. Please try again or contact an administrator");


                }
            }
        }
        private void gridTrainingPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //determine if clicked cell is a delete button or not
            bool isButton = (!gridTrainingPlan.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("")) && !(gridTrainingPlan.Rows[e.RowIndex].Cells[3].Value.ToString() == null);

            // check if a "Delete Booking" button was pressed
            if (e.ColumnIndex == 3 && isButton)
            {      
                    DeleteBooking_CellClick(e);     
            }


            // determine if clicked cell is start training a button or not
            isButton = (!gridTrainingPlan.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("")) && !(gridTrainingPlan.Rows[e.RowIndex].Cells[4].Value.ToString() == null);

            //Check if Start Training button was pressed
            if (e.ColumnIndex == 4 && isButton)
            {            
                    StartTraining_CellClick(e);
            }
        }
    }
}
