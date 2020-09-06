using EmployeeTrainingPlatformLibrary.Logic.General;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlatformUI.General;
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
    public partial class AdminEditUserViewerForm : Form
    {
        GeneralUILogic uiLogic = new GeneralUILogic();
        AdminEditUserLogic logic = new AdminEditUserLogic();
        GeneralPermissionLogic permissionLogic = new GeneralPermissionLogic();

        const string ENTRY_TEXT = "Here you can assign an administrator role to an employee. With the search you are able to specify the department and the name of employees.";
        public AdminEditUserViewerForm()
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
            entryTextBox.Text = ENTRY_TEXT;

            //init grid
            InitGrid();
        }

            /// <summary>
            /// Initialize grid.
            /// Containing: - init columns
            ///             - populate grid
            ///             - set visibility of make admin button
            ///             - set layout
            /// </summary>
            public void InitGrid()
            {
                InitColumnsOfGrid();

                uiLogic.UpdateUserSearchResult(
                    gridEmployee, 
                    inputName.Text, 
                    inputDepartment.Text,
                    true);

            SetVisibilityButtonColumn();

                uiLogic.SetLayoutOfGrid(gridEmployee);
            }

        /// <summary>
        /// Initialize columns of grid (including clear all rows and columns first)
        /// </summary>
        private void InitColumnsOfGrid()
        {
            gridEmployee.Rows.Clear();
            gridEmployee.Columns.Clear();


            uiLogic.AddTextBoxColumnToGrid(
                gridEmployee,
                "cEmployeeId",
                "",
                0);

            gridEmployee.Columns[0].Visible = false;

            uiLogic.AddTextBoxColumnToGrid(
                gridEmployee,
                "cName",
                "Name",
                1);

            uiLogic.AddTextBoxColumnToGrid(
              gridEmployee,
              "cDepartment",
              "Department",
              2);

            uiLogic.AddTextBoxColumnToGrid(
             gridEmployee,
             "cRole",
             "Role",
             3);



            uiLogic.AddButtonColumnToGrid(
                gridEmployee,
                "btnAssignAdmin",
                "",
                "Make administrator",
                4,
                Permission.PERM_ASSIGN_ROLE);

        
        }

        /// <summary>
        /// Set visibility of button make administrator
        /// </summary>
        private void SetVisibilityButtonColumn()
        {
            // Set "visibility" of button to make administrator
            for (int i = 0; i < gridEmployee.Rows.Count; i++)

            {
                Role tmp_role = uiLogic.MapDisplayeValuetoRole(gridEmployee.Rows[i].Cells[3].Value.ToString());

                //If role is already admin, don't display button
                if (tmp_role.Equals(Role.ROLE_ADMIN))
                {

                    DataGridViewTextBoxCell emptyCell = new DataGridViewTextBoxCell();
                    emptyCell.Value = "";
                    gridEmployee.Rows[i].Cells[4] = emptyCell;
                    emptyCell.ReadOnly = true;
                }

            }
        }
        private void gridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //determine if clicked cell is a make admin button or not
            bool isButton = (!gridEmployee.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("")) && !(gridEmployee.Rows[e.RowIndex].Cells[4].Value.ToString() == null);

            //Event -> Make administrator
            if (e.ColumnIndex == 4 && isButton)
            {
                //Let administrator confirm the assignment
                if(uiLogic.ValidateUserEntry(
                    $"Do you really want to assign an administrator role to {gridEmployee.Rows[e.RowIndex].Cells[1].Value} ?"
                    ,"Assign Administrator Role"))
                {
                    int employeeId = 0;

                    //Get training id from grid cell
                    string employeeIdString = gridEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();

                    //Try to pars string id into int
                    try
                    {
                        employeeId = int.Parse(employeeIdString);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured. Please try again or contact an administrator.");
                        Debug.WriteLine($"Error during parsing employee id ({employeeIdString}) to int. Error Message: {ex.Message}");
                        return;
                    }

                    try
                    {
                        //call logic to assign role to user
                        logic.AssignAdminRole(employeeId);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"An error occured during assigning role Admin to employee with id {employeeId}. Error: {ex.Message}.");
                        MessageBox.Show("An error occured while assigning the role administrator. Please try again or contact an administrator");
                        return;
                    }

                    MessageBox.Show($"Successfully assigned role administrator to {gridEmployee.Rows[e.RowIndex].Cells[1].Value}.");
                    InitGrid();

                }
            }
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void inputDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitGrid();
        }
    }
}
