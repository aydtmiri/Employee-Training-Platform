using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;


namespace EmployeeTrainingPlatformUI
{
   
    public partial class SearchTrainingUserControl : UserControl
    {
        public TextBox Title { set { } get { return this.inputTitle; } }
        public ComboBox Department { set { }  get { return this.inputDepartment; } }

        public ListBox Trainingresult { set { } get { return this.outputTrainingResult; }}
        public EventHandler TitleChanged { get; set; }
        public EventHandler DepartmentChanged { get; set; }
        public EventHandler TrainingSelected { get; set; }

        

        public SearchTrainingUserControl()
        {        
            InitializeComponent();

        }

        private void inputTitle_TextChanged(object sender, EventArgs e)
        {
            this.TitleChanged?.Invoke(this, e);
        }

        private void inputDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DepartmentChanged?.Invoke(this, e);
        }

        private void outputTrainingResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TrainingSelected?.Invoke(this, e);
        }
    }
}
