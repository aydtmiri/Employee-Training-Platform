using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Model;
using System;
using EmployeeTrainingPlatformUI.MainForm;
using System.Text;
using System.Windows.Forms;

namespace EmployeeTrainingPlatformUI.General
{
    public partial class LoginViewerForm : Form
    {

        private Form activeForm = null;
        public LoginLogic logic { get; set; } = new LoginLogic();
        public LoginViewerForm()
        {
            InitializeComponent();

            //TESTING
            inputEmailAddress.Text = "john.doe@gmail.com";
            inputPassword.Text = "password";
        }

        private void openForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = form;

            form.BringToFront();
            form.Show();


        }

        /// <summary>
        /// Validate if user input is valid
        /// </summary>
        /// <returns>error message</returns>
        private string ValidateForm()
        {
            StringBuilder output = new StringBuilder();

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


            return output.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateForm();
            if(errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
            else
                try
                {
                    if(logic.Login(inputEmailAddress.Text, inputPassword.Text))
                    {
                        this.Hide();
                        MainViewerForm form = new MainViewerForm();
                        form.ShowDialog();
                        this.Close();
                    }else
                    {
                        MessageBox.Show("You have entered an invalid username or password");
                    }

                }

                 
                catch(TrainingPlatformException ex)
                {
                    MessageBox.Show(ex.Message);
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured while logging in. Please contact an administrator.");
                    System.Diagnostics.Debug.WriteLine($"ERROR during Log in: {ex.Message}");
                    
                }

            

            
            




        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            openForm(new EmployeeCreateAccountViewerForm());
        }
    }
}
