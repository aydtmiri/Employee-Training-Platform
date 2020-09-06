using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EmployeeTrainingPlatformUI.User_Control
{
    public partial class SearchUserControl : UserControl
    {
        public TextBox Fullname { get { return this.inputName; } set { this.inputName.Text = value.Text; } }
        public ComboBox Department { get { return this.inputDepartment; } set { this.inputDepartment = value; } }
        public DataGridView SelectUser { get { return this.gridSelectUser; } set { } }

        public EventHandler NameChanged { get; set; }
        public EventHandler DepartmentChanged { get; set; }
        public DataGridViewCellEventHandler UserSelected { get; set; }

        

        public SearchUserControl()
        {
            InitializeComponent();


        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            this.NameChanged?.Invoke(this, e);
        }

        private void inputDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DepartmentChanged?.Invoke(this, e);
        }

        private void gridSelectUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.UserSelected?.Invoke(this, e);
        }
    }
}
