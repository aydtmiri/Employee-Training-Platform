using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EmployeeTrainingPlatformLibrary.Logic;

namespace EmployeeTrainingPlatformUI.User_Control
{
    public partial class ChangeUserCredentials : UserControl
    {
        public TextBox EmailAddress { get{ return this.inputEmailAddress; } set { } }
        public TextBox CurrentPassword { get { return this.inputOldPassword; } set {  } }
        public TextBox NewPassword { get { return this.inputNewPassword; } set {  } }
        public ChangeUserCredentials()
        {
            InitializeComponent();

            
        }
    }
}
