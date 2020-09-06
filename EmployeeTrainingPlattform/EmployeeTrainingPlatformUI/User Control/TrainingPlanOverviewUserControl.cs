using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EmployeeTrainingPlatformUI.User_Control
{
    public partial class TrainingPlanOverviewUserControl : UserControl
    {
        public DataGridView GridTrainingPlan { get; set; }
        public EventHandler TrainingSelected { get; set; }
        public TrainingPlanOverviewUserControl()
        {
            InitializeComponent();
        }

        private void gridTrainingPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TrainingSelected?.Invoke(this, e);
        }
    }
}
