namespace EmployeeTrainingPlatformUI.Admin_Forms
{
    partial class AdminEditTrainingPlanViewerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridUserOverview = new System.Windows.Forms.DataGridView();
            this.overviewHeaderLabel = new System.Windows.Forms.Label();
            this.showNameLabel = new System.Windows.Forms.Label();
            this.searchUserControl1 = new EmployeeTrainingPlatformUI.User_Control.SearchUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(629, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training Plan";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNote.BackColor = System.Drawing.Color.White;
            this.textBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNote.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxNote.Location = new System.Drawing.Point(24, 122);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.ReadOnly = true;
            this.textBoxNote.Size = new System.Drawing.Size(1141, 115);
            this.textBoxNote.TabIndex = 2;
            this.textBoxNote.Text = "<none>";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Training";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Department";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 76;
            // 
            // gridUserOverview
            // 
            this.gridUserOverview.AllowUserToAddRows = false;
            this.gridUserOverview.AllowUserToOrderColumns = true;
            this.gridUserOverview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridUserOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridUserOverview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridUserOverview.BackgroundColor = System.Drawing.Color.White;
            this.gridUserOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUserOverview.Location = new System.Drawing.Point(14, 710);
            this.gridUserOverview.Name = "gridUserOverview";
            this.gridUserOverview.RowHeadersVisible = false;
            this.gridUserOverview.Size = new System.Drawing.Size(1279, 339);
            this.gridUserOverview.TabIndex = 1;
            this.gridUserOverview.Text = "dataGridView1";
            this.gridUserOverview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUserOverview_CellClick);
            // 
            // overviewHeaderLabel
            // 
            this.overviewHeaderLabel.AutoSize = true;
            this.overviewHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overviewHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.overviewHeaderLabel.Location = new System.Drawing.Point(14, 666);
            this.overviewHeaderLabel.Name = "overviewHeaderLabel";
            this.overviewHeaderLabel.Size = new System.Drawing.Size(181, 32);
            this.overviewHeaderLabel.TabIndex = 3;
            this.overviewHeaderLabel.Text = "Training plan of";
            // 
            // showNameLabel
            // 
            this.showNameLabel.AutoSize = true;
            this.showNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.showNameLabel.Location = new System.Drawing.Point(198, 666);
            this.showNameLabel.Name = "showNameLabel";
            this.showNameLabel.Size = new System.Drawing.Size(106, 32);
            this.showNameLabel.TabIndex = 3;
            this.showNameLabel.Text = "<name>";
            // 
            // searchUserControl1
            // 
            this.searchUserControl1.BackColor = System.Drawing.Color.White;
            this.searchUserControl1.DepartmentChanged = null;
            this.searchUserControl1.Location = new System.Drawing.Point(12, 234);
            this.searchUserControl1.Name = "searchUserControl1";
            this.searchUserControl1.NameChanged = null;
            this.searchUserControl1.Size = new System.Drawing.Size(1005, 391);
            this.searchUserControl1.TabIndex = 5;
            this.searchUserControl1.UserSelected = null;
            // 
            // AdminEditTrainingPlanViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 1061);
            this.Controls.Add(this.searchUserControl1);
            this.Controls.Add(this.showNameLabel);
            this.Controls.Add(this.overviewHeaderLabel);
            this.Controls.Add(this.gridUserOverview);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.label1);
            this.Name = "AdminEditTrainingPlanViewerForm";
            this.Text = "AdminEditTrainingPlanViewerForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridUserOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView gridUserOverview;
        private System.Windows.Forms.Label overviewHeaderLabel;
        private System.Windows.Forms.Label showNameLabel;
        private User_Control.SearchUserControl searchUserControl1;
    }
}