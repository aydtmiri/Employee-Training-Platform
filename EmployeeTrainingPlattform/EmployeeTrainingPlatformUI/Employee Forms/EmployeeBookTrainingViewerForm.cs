using System;
using System.Diagnostics;
using System.Windows.Forms;
using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Logic.General;
using EmployeeTrainingPlatformLibrary.Model;

namespace EmployeeTrainingPlatformUI
{
    public partial class EmployeeBookTrainingViewerForm : Form
    {
        GeneralUILogic uiLogic = new GeneralUILogic();
        EmployeeBookTrainingLogic employeeBookTrainingLogic = new EmployeeBookTrainingLogic();
        GeneralPermissionLogic permissionLogic = new GeneralPermissionLogic();

        public EmployeeBookTrainingViewerForm()
        {
            InitializeComponent();
            InitForm();

        }

        /// <summary>
        /// Initiliaze form.
        /// Includes:   - set visibility of button
        ///             - init user control
        /// </summary>
        private void InitForm()
        {
            //set visibility of book training button
            btnBookTraining.Enabled = permissionLogic.HasUserPermission(Permission.PERM_BOOK_TRAINING);
            

            InitUserControl();
        }

        /// <summary>
        /// Initialize User Control
        /// Including:  - Fill search results
        ///             - set visibility
        ///             - assign event handler
        /// </summary>
        private void InitUserControl()
        {
            //fill search results
            uiLogic.UpdateTrainingSearchResult(
              searchTrainingUserControl1.Trainingresult,
              searchTrainingUserControl1.Title.Text,
              searchTrainingUserControl1.Department.Text,
              false);

            trainingOverviewUserControl1.Visible = false;

            uiLogic.PopulateDepartmentDropdown(searchTrainingUserControl1.Department);

            //assign EventHandler
            searchTrainingUserControl1.TitleChanged += new EventHandler(UserControl_TitleChanged);
            searchTrainingUserControl1.DepartmentChanged += new EventHandler(UserControl_DepartmentChanged);
            searchTrainingUserControl1.TrainingSelected += new EventHandler(UserControl_TrainingSelected);
            trainingOverviewUserControl1.OpenRequirement += new EventHandler(UserControl_OpenRequirement);



        }

        protected void UserControl_OpenRequirement(object sender, EventArgs e)
        {
            //show details about requirement
            uiLogic.showSelectedTraining(
               trainingOverviewUserControl1.Requiremnt.Text,
               trainingOverviewUserControl1.Title,
               trainingOverviewUserControl1.Department,
               trainingOverviewUserControl1.Requiremnt,
               trainingOverviewUserControl1.Description);

        }

        protected void UserControl_TitleChanged(object sender, EventArgs e)
        {
            //update search result when a title is entered
            uiLogic.UpdateTrainingSearchResult(
                searchTrainingUserControl1.Trainingresult,
                searchTrainingUserControl1.Title.Text,
                searchTrainingUserControl1.Department.Text,
                false);

        }

        protected void UserControl_DepartmentChanged(object sender, EventArgs e)
        {
            //update search result when department is selected
            uiLogic.UpdateTrainingSearchResult(
                searchTrainingUserControl1.Trainingresult,
                searchTrainingUserControl1.Title.Text,
                searchTrainingUserControl1.Department.Text,
                false);
        }

        protected void UserControl_TrainingSelected(object sender, EventArgs e)
        {
            //show details abozt selected training
            uiLogic.showSelectedTraining(
                searchTrainingUserControl1.Trainingresult.SelectedItem.ToString(),
                trainingOverviewUserControl1.Title,
                trainingOverviewUserControl1.Department,
                trainingOverviewUserControl1.Requiremnt,
                trainingOverviewUserControl1.Description);

            trainingOverviewUserControl1.Visible = true;


        }
        /// <summary>
        /// Validate user input
        /// </summary>
        /// <returns>Error message</returns>
        private string ValidateForm()
        {
            string errorMessage = "";

            if (trainingOverviewUserControl1.Title.Text.Equals("<none>"))
            {
                errorMessage = "Please select a training.";
            }

            return errorMessage;
        }

        private void trainingInformationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Check if there were error during form validation. If not, book training
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBookTraining_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateForm();

            //check if there are error. if not, proceed with logic
            if (errorMessage.Length == 0)
            {
                try
                {
                    //book training
                    employeeBookTrainingLogic.BookTraining(trainingOverviewUserControl1.Title.Text);

                  

                }
                catch (TrainingPlatformException ex)
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

                MessageBox.Show("Successfully booked training. It is now listed in the tab Training Plan.");
                ResetForm();

            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ResetForm()
        {
            //reset search
            searchTrainingUserControl1.Trainingresult = new ListBox();
            searchTrainingUserControl1.Title.Text = "";
            searchTrainingUserControl1.Department.Items.Clear();


            //reset dropdown and search result

            uiLogic.UpdateTrainingSearchResult(
                searchTrainingUserControl1.Trainingresult,
                searchTrainingUserControl1.Title.Text,
                searchTrainingUserControl1.Department.Text,
                false);
            uiLogic.PopulateDepartmentDropdown(searchTrainingUserControl1.Department);

            //hide overview
            trainingOverviewUserControl1.Visible = false;
        }


        private void searchTrainingUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void headlineCookTraining_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeBookTrainingViewerForm_Load(object sender, EventArgs e)
        {

        }
    }


}
