namespace EmployeeTrainingPlatformUI.Employee_Forms.EmployeeTrainingPlanViewerForm
{
    partial class EmployeeTrainingPlanViewerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headlineTrainingPlan = new System.Windows.Forms.Label();
            this.cEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTraining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.trainingOverviewUserControl = new EmployeeTrainingPlatformUI.User_Control.TrainingOverviewUserControl();
            this.gridTrainingPlan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainingPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // headlineTrainingPlan
            // 
            this.headlineTrainingPlan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headlineTrainingPlan.AutoSize = true;
            this.headlineTrainingPlan.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headlineTrainingPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.headlineTrainingPlan.Location = new System.Drawing.Point(629, 22);
            this.headlineTrainingPlan.Name = "headlineTrainingPlan";
            this.headlineTrainingPlan.Size = new System.Drawing.Size(219, 50);
            this.headlineTrainingPlan.TabIndex = 0;
            this.headlineTrainingPlan.Text = "Training Plan";
            this.headlineTrainingPlan.Click += new System.EventHandler(this.headlineTrainingPlan_Click);
            // 
            // cEmployee
            // 
            this.cEmployee.HeaderText = "Employee";
            this.cEmployee.Name = "cEmployee";
            this.cEmployee.ReadOnly = true;
            this.cEmployee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cEmployee.Width = 84;
            // 
            // cTraining
            // 
            this.cTraining.HeaderText = "Training";
            this.cTraining.Name = "cTraining";
            this.cTraining.ReadOnly = true;
            this.cTraining.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cTraining.Width = 74;
            // 
            // cDepartment
            // 
            this.cDepartment.HeaderText = "Department";
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.ReadOnly = true;
            this.cDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cDepartment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cDepartment.Width = 76;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNote.BackColor = System.Drawing.Color.White;
            this.textBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNote.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxNote.Location = new System.Drawing.Point(12, 125);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.ReadOnly = true;
            this.textBoxNote.Size = new System.Drawing.Size(884, 152);
            this.textBoxNote.TabIndex = 2;
            // 
            // trainingOverviewUserControl
            // 
            this.trainingOverviewUserControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trainingOverviewUserControl.BackColor = System.Drawing.Color.White;
            this.trainingOverviewUserControl.Location = new System.Drawing.Point(12, 553);
            this.trainingOverviewUserControl.Name = "trainingOverviewUserControl";
            this.trainingOverviewUserControl.OpenRequirement = null;
            this.trainingOverviewUserControl.Size = new System.Drawing.Size(1230, 507);
            this.trainingOverviewUserControl.TabIndex = 3;
            // 
            // gridTrainingPlan
            // 
            this.gridTrainingPlan.AllowUserToAddRows = false;
            this.gridTrainingPlan.AllowUserToOrderColumns = true;
            this.gridTrainingPlan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridTrainingPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridTrainingPlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridTrainingPlan.BackgroundColor = System.Drawing.Color.White;
            this.gridTrainingPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrainingPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEmployee,
            this.cTraining,
            this.cDepartment});
            this.gridTrainingPlan.Location = new System.Drawing.Point(12, 283);
            this.gridTrainingPlan.Name = "gridTrainingPlan";
            this.gridTrainingPlan.RowHeadersVisible = false;
            this.gridTrainingPlan.Size = new System.Drawing.Size(1316, 264);
            this.gridTrainingPlan.TabIndex = 1;
            this.gridTrainingPlan.Text = "dataGridView1";
            this.gridTrainingPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTrainingPlan_CellClick);
            this.gridTrainingPlan.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTrainingPlan_CellContentDoubleClick);
            // 
            // EmployeeTrainingPlanViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 1061);
            this.Controls.Add(this.trainingOverviewUserControl);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.gridTrainingPlan);
            this.Controls.Add(this.headlineTrainingPlan);
            this.Name = "EmployeeTrainingPlanViewerForm";
            this.Text = "EmployeeTrainingOverview";
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainingPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headlineTrainingPlan;
        private System.Windows.Forms.DataGridView gridTrainingPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTraining;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDepartment;
        private System.Windows.Forms.TextBox textBoxNote;
        private User_Control.TrainingOverviewUserControl trainingOverviewUserControl;
    }
}