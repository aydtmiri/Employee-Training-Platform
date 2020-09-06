
using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Logic.General;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Automation;
using System.Windows.Forms;

namespace EmployeeTrainingPlatformUI
{

    public class GeneralUILogic
    {

        GeneralTrainingLogic trainingLogic = new GeneralTrainingLogic();
        GeneralEmployeeLogic employeeLogic = new GeneralEmployeeLogic();
        GeneralPermissionLogic permissionLogic = new GeneralPermissionLogic();


        /// <summary>
        /// Shows details about selected training in Panel
        /// </summary>
        /// <param name="trainingToBeDisplayed">Selected traing which details are to be displayed</param>
        /// <param name="title">Label that corresponds to title</param>
        /// <param name="department">Department that corresponds to title</param>
        /// <param name="requirement">Requirement that corresponds to title</param>
        /// <param name="description">Descriptiob that corresponds to title</param>
        public void showSelectedTraining(string trainingToBeDisplayed, Label title, Label department, Label requirement, TextBox description)
        {


            Training training = null;

            try
            {
                //get training object with same title as selected training
                training = trainingLogic.GetSelectedTraining(trainingToBeDisplayed);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, Please try again or contact an asministrator");
                Debug.WriteLine($"ERROR: {ex.Message}");
            }


            if (training != null)
            {

                // fill overview panel
                title.Text = training.Title;
                department.Text = training.Department.ToString();


                requirement.Text = "No requirement";
                requirement.Font = new Font(requirement.Font.Name, 16, FontStyle.Regular);
                requirement.ForeColor = System.Drawing.ColorTranslator.FromHtml("#696969");



                if (training.Requirement != null)
                {
                    requirement.Text = training.Requirement;
                    requirement.Font = new Font(requirement.Font.Name, 16, FontStyle.Underline);
                    requirement.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3399FF");

                }



                description.Text = training.Description;

            }
            else
            {
                MessageBox.Show("There was an error while loading the training data. Please try again or contact an administrator.");
            }

        }


        public GeneralDepartmentLogic departmentLogic { get; set; }
        public GeneralUILogic()
        {
            departmentLogic = new GeneralDepartmentLogic();
        }

        /// <summary>
        /// Populates ComboBox with departments names
        /// </summary>
        /// <param name="inputDepartment">ComboBox with department names</param>
        public void PopulateDepartmentDropdown(ComboBox inputDepartment)
        {
            List<string> departments = departmentLogic.GetAllDepartmentnames();

            inputDepartment.Items.Clear();

            inputDepartment.Items.Add("Select department");
            inputDepartment.SelectedIndex = inputDepartment.FindString("Select department");

            foreach (string tmp_department in departments)
            {
                inputDepartment.Items.Add(tmp_department);
            }

        }

        /// <summary>
        /// Map Role object to string value which is to be displayed
        /// </summary>
        /// <param name="role">Role</param>
        /// <returns></returns>
        public string MapRoleToDisplayedValue(Role role)
        {
            if (role.Equals(Role.ROLE_ADMIN))
                return "Administrator";

            if (role.Equals(Role.ROLE_EMPLOYEE))
                return "Employee";

            return "";
        }

        /// <summary>
        /// Map displayed value to enum
        /// </summary>
        /// <param name="value">displaye value of role</param>
        /// <returns></returns>
        public Role MapDisplayeValuetoRole(string value)
        {
            if (value.Equals("Administrator"))
                return Role.ROLE_ADMIN;

            return Role.ROLE_EMPLOYEE;
        }


        /// <summary>
        /// Updates title of trainings in List Box according to search criteria
        /// </summary>
        /// <param name="list">Listbox where titles are displayed</param>
        /// <param name="title">Title of training</param>
        /// <param name="department">department of training</param>
        /// <param name="useAllTrainings">parameter to determine, if search result should consider all training available (useAllTrainings = true) or only trainings that are not booked already (useAllTrainings = false)</param>
        public void UpdateTrainingSearchResult(ListBox list, string title, string department, bool useAllTrainings)
        {

            List<Training> listOfTrainings = new List<Training>();

            //check if al trainings available should be used (true) or only the ones, that aren't book already (false)

            foreach (var tmp_training in Training.Trainings)
            {
                if (useAllTrainings)
                {
                    listOfTrainings.Add(tmp_training);
                }
                else
                {
                    if (!Global.employee.TrainingBooking.ContainsKey(tmp_training.Title))
                    {
                        listOfTrainings.Add(tmp_training);
                    }
                }

            }

            if (department.Equals("Select department"))
            {
                department = null;
            }

            //reset listBox
            list.Items.Clear();

            foreach (var training in listOfTrainings)
            {


                // scenario: title is filled and department is selected
                if (!string.IsNullOrEmpty(department) && !string.IsNullOrEmpty(title))
                {
                    //Add training if it belongs to selected department and contains entered title
                    if (training.Department.ToString().Equals(Regex.Replace(department, @"\s+", "")) && training.Title.Contains(title))
                    {
                        list.Items.Add(training.Title);
                    }
                }
                else
                {

                    //scenario:  department is selected and name is empty
                    if (!string.IsNullOrEmpty(department) && string.IsNullOrEmpty(title))
                    {
                        // Add training if it belongs to selected department
                        if (training.Department.ToString().Equals(Regex.Replace(department, @"\s+", "")))
                        {
                            list.Items.Add(training.Title);
                        }
                    }
                    else
                    {

                        //scenario: title is filled and department empty
                        if (string.IsNullOrEmpty(department) && !string.IsNullOrEmpty(title))
                        {
                            //Add training if it contains entered title

                            if (training.Title.Contains(title))
                            {
                                list.Items.Add(training.Title);
                            }

                        }
                        else
                        {
                            list.Items.Add(training.Title);
                        }
                    }
                }





            }
        }


        #region GRID
        /// <summary>
        /// Updates user in grig according to search criteria
        /// </summary>
        /// <param name="grid">Grid to display user</param>
        /// <param name="name">name of employee</param>
        /// <param name="department">department whee employee works</param>
        /// /// <param name="displayRole">detmernies whether a row with a role columns or not is added</param>
        public void UpdateUserSearchResult(DataGridView grid, string name, string department, bool displayRole)
        {
        

            //get a list with all employees
            List<Employee> employees = employeeLogic.GetAllEmployees();

            //set department null if no department is selected. if it is null, it is not considered during the search
            if (department.Equals("Select department"))
            {
                department = null;
            }




            foreach (var employee in employees)
            {
                string fullname = employeeLogic.GetFullName(employee);


                //scenario: department is selected and name is entered
                if (!string.IsNullOrEmpty(department) && !string.IsNullOrEmpty(name))
                {
                    // scenario: name is filled and department is selected
                    if (employee.Department.ToString().Equals(Regex.Replace(department, @"\s+", "")) && fullname.Contains(name))
                    {

                        UpdateUserSearchResultAddRow(grid,employee.Id.ToString(), fullname, employee.Department.ToString(), employee.Role, displayRole);
                     
                    }
                }
                else
                {

                    //scenario:  department is selected and name is empty
                    if (!string.IsNullOrEmpty(department) && string.IsNullOrEmpty(name))
                    {
                        //Add user if he/she works in selected department
                        if (employee.Department.ToString().Equals(Regex.Replace(department, @"\s+", "")))
                        {

                            UpdateUserSearchResultAddRow(grid, employee.Id.ToString(), fullname, employee.Department.ToString(), employee.Role, displayRole);

                        }
                    }
                    else
                    {

                        //scenario: title is filled and department empty
                        if (string.IsNullOrEmpty(department) && !string.IsNullOrEmpty(name))
                        {
                            //Add user if name  contains entered name

                            if (fullname.Contains(name))
                            {
                                UpdateUserSearchResultAddRow(grid, employee.Id.ToString(), fullname, employee.Department.ToString(), employee.Role, displayRole);
                            }

                        }
                        else
                        {
                            UpdateUserSearchResultAddRow(grid, employee.Id.ToString(), fullname, employee.Department.ToString(), employee.Role, displayRole);
                        }
                    }
                }

            }
        }

        private void UpdateUserSearchResultAddRow(DataGridView grid ,string employeeId, string name, string department, Role role, bool showRole)
        {
            string[] tmp_row = new string[] { };

            if (showRole)
            {
                tmp_row = new string[] { employeeId, name, department, MapRoleToDisplayedValue(role)};
            }
            else
            {
                tmp_row = new string[] { employeeId, name, department};
            }

            
            grid.Rows.Add(tmp_row);
        }



        /// <summary>
        /// Initiliaze columns and layout of a select user grid
        /// </summary>
        /// <param name="grid">Grid</param>
        public void InitSelectUserGrid(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            AddTextBoxColumnToGrid(
                grid,
                "cEmployeeId",
                "Employee Id",
                0);

            AddTextBoxColumnToGrid(
                grid,
                "cEmployee",
                "Employee",
                1);

            AddTextBoxColumnToGrid(
              grid,
              "cDepartment",
              "Department",
              2);

            AddButtonColumnToGrid(
             grid,
             "btnSelect",
             "",
             "Select",
              3,
              Permission.PERM_OPEN_USER_DETAILS);

            grid.Columns[0].Visible = false;


            SetLayoutOfGrid(grid);
        }



        /// <summary>
        /// Adds button column to grid
        /// </summary>
        /// <param name="grid">DataGridView where columns is inserted</param>
        /// <param name="name">name of button column</param>
        /// <param name="headerText">header text of button column</param>
        /// <param name="text">Text to display on buttons of button column</param>
        /// <param name="columnIndex">Index where column is inserted</param>
        public void AddButtonColumnToGrid(DataGridView grid, string name, string headerText, string text, int columnIndex, Permission permission)
        {
            // Initialize the button column.
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

            buttonColumn.Name = name;
            buttonColumn.HeaderText = headerText;
            buttonColumn.Text = text;
            buttonColumn.FlatStyle = FlatStyle.Flat;
            buttonColumn.Visible = permissionLogic.HasUserPermission(permission);
            
          

            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the control.
            grid.Columns.Insert(columnIndex, buttonColumn);
        }

        /// <summary>
        /// Adds button column to grid
        /// </summary>
        /// <param name="grid">DataGridView where columns is inserted</param>
        /// <param name="name">name of button column</param>
        /// <param name="headerText">header text of button column</param>
        /// <param name="text">Text to display on buttons of button column</param>
        /// <param name="columnIndex">Index where column is inserted</param>
        public void AddDeleteButtonColumnToGrid(DataGridView grid, string name, string headerText, string text, int columnIndex, Permission permission)
        {
            // Initialize the button column.
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

            buttonColumn.Name = name;
            buttonColumn.HeaderText = headerText;
            buttonColumn.Text = text;
            buttonColumn.FlatStyle = FlatStyle.Flat;
            buttonColumn.DefaultCellStyle.BackColor = Color.Red;
            buttonColumn.DefaultCellStyle.ForeColor = Color.White;
            buttonColumn.Visible = permissionLogic.HasUserPermission(permission);

            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the control.
            grid.Columns.Insert(columnIndex, buttonColumn);
        }

        /// <summary>
        /// Adds text column to grid
        /// </summary>
        /// <param name="grid">DataGridView where columns is inserted</param>
        /// <param name="name">name of  column</param>
        /// <param name="headerText">header text n column</param>
        /// <param name="text">Text to display column</param>
        /// <param name="columnIndex">Index where column is inserted</param>
        public void AddTextBoxColumnToGrid(DataGridView grid, string name, string headerText, int columnIndex)
        {
            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = name;
            textColumn.HeaderText = headerText;
            textColumn.ReadOnly = true;
           


            grid.Columns.Insert(columnIndex, textColumn);


        }

   



        /// <summary>
        /// Shows a message box to validate user entry
        /// </summary>
        /// <param name="message">Message of Message Box</param>
        /// <param name="caption">Caption of Message Box</param>
        /// <returns>bool value which correspondes to user decision</returns>
        public bool ValidateUserEntry(string message, string caption)
        {
            string boxMessage = message;
            string boxCaption = caption;

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(boxMessage, boxCaption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public void SetLayoutOfGrid(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.Font = new Font(grid.Font.Name, 14, FontStyle.Regular);
            grid.ForeColor = System.Drawing.ColorTranslator.FromHtml("#696969");
        }

        #endregion

    }
}
