using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EmployeeTrainingPlatformLibrary.Model;

namespace EmployeeTrainingPlatformUI.User_Control
{
    public partial class TrainingOverviewUserControl : UserControl
    {
        public Label Title { set { this.selectedTrainingValue.Text = value.Text; } get { return this.selectedTrainingValue; } }
        public Label Department { set { this.departmentValue.Text = value.Text; } get { return this.departmentValue; } }
        public Label Requiremnt { set { this.inputRequirement.Text = value.Text; } get { return this.inputRequirement; } }
        public TextBox Description { set { this.descriptionValue.Text = value.Text; } get { return this.descriptionValue; } }

        public EventHandler OpenRequirement { get; set; }
        public TrainingOverviewUserControl()
        {
            InitializeComponent();
        }

        private void TrainingOverviewUserControl_Load(object sender, EventArgs e)
        {

        }

        private void inputRequirement_Click(object sender, EventArgs e)
        {
            //Display information about requirement
            if (!Requiremnt.Text.Equals("No requirement"))
            {
                this.OpenRequirement?.Invoke(this, e);
            }
        }

        private void inputRequirement_MouseHover(object sender, EventArgs e)
        {
            //Change color of link when mouse is hovering over it
            if(!Requiremnt.Text.Equals("No requirement"))
            {
                Requiremnt.ForeColor =  System.Drawing.ColorTranslator.FromHtml("#a11212");
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
            }
        }

        private void inputRequirement_MouseLeave(object sender, EventArgs e)
        {
            //Change colot of link back to the original color 
            if (!Requiremnt.Text.Equals("No requirement"))
            {
                Requiremnt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3399FF");
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            }

        }
    }
}
