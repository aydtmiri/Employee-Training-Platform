namespace EmployeeTrainingPlatformUI.User_Control
{
    partial class TrainingPlanOverviewUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTraining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrainingStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gridTrainingPlan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainingPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // cEmployee
            // 
            this.cEmployee.HeaderText = "Employee";
            this.cEmployee.Name = "cEmployee";
            this.cEmployee.ReadOnly = true;
            // 
            // cTraining
            // 
            this.cTraining.HeaderText = "Training";
            this.cTraining.Name = "cTraining";
            this.cTraining.ReadOnly = true;
            // 
            // cDepartment
            // 
            this.cDepartment.HeaderText = "Department";
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.ReadOnly = true;
            // 
            // cTrainingStatus
            // 
            this.cTrainingStatus.HeaderText = "Training Status";
            this.cTrainingStatus.Name = "cTrainingStatus";
            // 
            // cDelete
            // 
            this.cDelete.HeaderText = "";
            this.cDelete.Name = "cDelete";
            // 
            // gridTrainingPlan
            // 
            this.gridTrainingPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrainingPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEmployee,
            this.cTraining,
            this.cDepartment,
            this.cTrainingStatus,
            this.cDelete});
            this.gridTrainingPlan.Location = new System.Drawing.Point(58, 45);
            this.gridTrainingPlan.Name = "gridTrainingPlan";
            this.gridTrainingPlan.Size = new System.Drawing.Size(721, 159);
            this.gridTrainingPlan.TabIndex = 0;
            this.gridTrainingPlan.Text = "dataGridView1";
            this.gridTrainingPlan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTrainingPlan_CellDoubleClick);
            // 
            // TrainingPlanOverviewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridTrainingPlan);
            this.Name = "TrainingPlanOverviewUserControl";
            this.Size = new System.Drawing.Size(832, 326);
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainingPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn cEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTraining;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDepartment;
        private System.Windows.Forms.DataGridViewComboBoxColumn cTrainingStatus;
        private System.Windows.Forms.DataGridViewButtonColumn cDelete;
        private System.Windows.Forms.DataGridView gridTrainingPlan;
    }
}
