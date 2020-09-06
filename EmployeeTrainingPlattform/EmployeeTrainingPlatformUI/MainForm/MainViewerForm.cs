using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlatformUI.Admin_Forms;
using EmployeeTrainingPlatformUI.Employee_Forms;
using EmployeeTrainingPlatformUI.Employee_Forms.EmployeeTrainingPlanViewerForm;
using EmployeeTrainingPlatformUI.General;
using EmployeeTrainingPlattformUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeTrainingPlatformUI.MainForm
{
    public partial class MainViewerForm : Form
    {
        #region properties
        // Menu Employee
        public Button MenuEmployee { get { return this.menuEmployee; } set { } }
        public Button SubMenuEditEmployee { get { return this.subMenuEditEmployee; } set { } }

        //Menu Training
        public Button MenuTraining { get { return this.menuTraining; } set { } }
        public Button SubMenuBookTraining { get { return this.subMenuBookTraining; } set{} }
        public Button SubMenuTrainingPlan { get { return this.subMenuTrainingPlan; } set { } }
        public Button SubMenuEditTrainingPlan { get { return this.subMenuEditTrainingPlan; } set { } }
        public Button SubMenuCreateTraining { get { return this.subMenuCreateTrainig; } set { } }
        public Button SubMenuEditTraining { get { return this.subMenuEditTraining; } set { } }
        //Menu User
        public Button MenuUser { get { return this.userSettingsMenuBar; } set { } }
        public Button SubMenuChangeUserSettings { get { return this.subMenuChangeSettings; } set { } }


        MainVisibilityController VisibilityController = new MainVisibilityController();

        private Form activeForm = null;

        GeneralUILogic uiLogic = new GeneralUILogic();
        GeneralRoleLogic roleLogic = new GeneralRoleLogic();



        #endregion

        public MainViewerForm()
        {
            InitializeComponent();
            customizeDesign();
            InitForm();

            

        }

        /// <summary>
        /// Open selected form in Panel
        /// </summary>
        /// <param name="childForm"></param>
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

           // visibilityController.SetVisibility(this);


        }
     
        /// <summary>
        /// Initialize Form.
        /// Contains:   - setting role dropdown
        /// </summary>
        private void InitForm()
        {


            if(roleLogic.IsAdmin())
            {
                PopulateRoleDropdown();
            }

            inputRole.Visible = roleLogic.IsAdmin();
            VisibilityController.SetVisibility(this);


        }


        /// <summary>
        /// Populate Role dropwdown
        /// </summary>
        private void PopulateRoleDropdown()
        {
            List<Role> roles = roleLogic.GetAllRoleNames();

            inputRole.Items.Clear();

            foreach (Role tmp_role in roles)
            {
                inputRole.Items.Add(uiLogic.MapRoleToDisplayedValue(tmp_role));
            }

            inputRole.SelectedIndex = inputRole.FindString(uiLogic.MapRoleToDisplayedValue(Role.ROLE_ADMIN));



        }
        /// <summary>
        /// Set visibility of all sub menus to false
        /// </summary>
        private void customizeDesign()
        {
            VisibilityController.SetVisibility(this);

            userSettingsSubMenuePanel.Visible = false;
            trainingSubMenuePanel.Visible = false;
            subMenuEditEmployee.Visible = false;

        }

        /// <summary>
        /// Hide sub menus, if they are visible
        /// </summary>
        private void hideSubMenu()
        {
            if(userSettingsSubMenuePanel.Visible)
                userSettingsSubMenuePanel.Visible = false;

            if (subMenuEditEmployee.Visible)
                subMenuEditEmployee.Visible = false;

            if (trainingSubMenuePanel.Visible)
                trainingSubMenuePanel.Visible = false;

        }

        /// <summary>
        /// set visibility of sub menu to true
        /// </summary>
        /// <param name="subMenu">Panel of submenu</param>
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;


        }






        #region Employees Menu
        private void menuEmployees_Click(object sender, EventArgs e)
        {
            //set visibility according to user role
            VisibilityController.SetVisibility(this);

        }
        private void menuEditEmployee_Click(object sender, EventArgs e)
        {
        
            try
            {
                hideSubMenu();
                //Open form "Edit Employee"
                openChildForm(new AdminEditUserViewerForm());
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occured . Please try again or contact an administrator.");
                return;
            }

        }

        #endregion

        #region Training Menu
        private void menuTraining_Click(object sender, EventArgs e)
        {
            //open sub menus
            showSubMenu(trainingSubMenuePanel);
            //set visibility according to user role
            VisibilityController.SetVisibility(this);

            subMenuEditEmployee.Visible = false;
        }

        private void subMenueBookTraining_Click(object sender, EventArgs e)
        {
            try
            {
                //open form "Book Training"
                openChildForm(new EmployeeBookTrainingViewerForm());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occured . Please try again or contact an administrator.");
                return;
            }

        }


        private void subMenuEditTrainingPlan_Click(object sender, EventArgs e)
        {
            try
            {
                //open form "Edit Training Plan"
                openChildForm(new AdminEditTrainingPlanViewerForm());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occured. Please try again or contact an administrator.");
                return;
            }
        }


        private void subMenuTrainingPlan_Click(object sender, EventArgs e)
        {
            try
            {
                //open form "Training Plan"
                openChildForm(new EmployeeTrainingPlanViewerForm());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occured. Please try again or contact an administrator.");
                return;
            }
           
        }
        private void subMenuCreateTraining_Click(object sender, EventArgs e)
        {
            try
            {
                //open form "Create Trainingplan"
                openChildForm(new AdminCreateTrainingViewerForm());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occured. Please try again or contact an administrator.");
                return;
            }
        }

        private void subMenuEditTraining_Click(object sender, EventArgs e)
        {
            try
            {
                //open form "Edit Training"
                openChildForm(new AdminEditTrainingViewerForm());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("An error occured. Please try again or contact an administrator.");
                return;
            }
        }
        #endregion



        #region User Menu

        private void userSettingsMenuBar_Click(object sender, EventArgs e)
        {

            //open sub menu buttons
            showSubMenu(userSettingsSubMenuePanel);
            //set visibility according to user role
            VisibilityController.SetVisibility(this);
            subMenuEditEmployee.Visible = false;
        }

        private void subMenueChangeSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new UserSettingsViewerForm());
          
        }



        #endregion

        private void logOut_Click(object sender, EventArgs e)
        {
            //perform logout logic ( reset Global user , Training and Employees)
            LogoutLogic logoutLogic = new LogoutLogic();
            logoutLogic.Logout();

            this.Hide();
            LoginViewerForm form = new LoginViewerForm();
            form.ShowDialog();
            this.Close();


        }

        private void inputRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.employee.Role = uiLogic.MapDisplayeValuetoRole(inputRole.Text);
           
            VisibilityController.SetVisibility(this);

            mainPanel.Controls.Clear();
         
        }
    }
}
