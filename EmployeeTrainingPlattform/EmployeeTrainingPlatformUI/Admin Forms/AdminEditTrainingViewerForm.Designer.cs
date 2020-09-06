namespace EmployeeTrainingPlatformUI
{
    partial class AdminEditTrainingViewerForm
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
            this.headlineEditTraining = new System.Windows.Forms.Label();
            this.entryTextLabel = new System.Windows.Forms.TextBox();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.inputDepartment = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.gridTrainingesult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainingesult)).BeginInit();
            this.SuspendLayout();
            // 
            // headlineEditTraining
            // 
            this.headlineEditTraining.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headlineEditTraining.AutoSize = true;
            this.headlineEditTraining.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headlineEditTraining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.headlineEditTraining.Location = new System.Drawing.Point(520, 8);
            this.headlineEditTraining.Name = "headlineEditTraining";
            this.headlineEditTraining.Size = new System.Drawing.Size(212, 50);
            this.headlineEditTraining.TabIndex = 0;
            this.headlineEditTraining.Text = "Edit Training";
            // 
            // entryTextLabel
            // 
            this.entryTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.entryTextLabel.BackColor = System.Drawing.Color.White;
            this.entryTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entryTextLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryTextLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.entryTextLabel.Location = new System.Drawing.Point(38, 98);
            this.entryTextLabel.Multiline = true;
            this.entryTextLabel.Name = "entryTextLabel";
            this.entryTextLabel.ReadOnly = true;
            this.entryTextLabel.Size = new System.Drawing.Size(1141, 97);
            this.entryTextLabel.TabIndex = 2;
            this.entryTextLabel.Text = "<none>";
            // 
            // inputTitle
            // 
            this.inputTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputTitle.Location = new System.Drawing.Point(202, 219);
            this.inputTitle.MaxLength = 100;
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(977, 35);
            this.inputTitle.TabIndex = 1;
            this.inputTitle.TextChanged += new System.EventHandler(this.inputTitle_TextChanged);
            // 
            // inputDepartment
            // 
            this.inputDepartment.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputDepartment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDepartment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputDepartment.FormattingEnabled = true;
            this.inputDepartment.Location = new System.Drawing.Point(202, 293);
            this.inputDepartment.Name = "inputDepartment";
            this.inputDepartment.Size = new System.Drawing.Size(214, 38);
            this.inputDepartment.TabIndex = 2;
            this.inputDepartment.SelectedIndexChanged += new System.EventHandler(this.inputDepartment_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.titleLabel.Location = new System.Drawing.Point(26, 225);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(57, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.departmentLabel.Location = new System.Drawing.Point(26, 296);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(129, 30);
            this.departmentLabel.TabIndex = 0;
            this.departmentLabel.Text = "Department:";
            // 
            // gridTrainingesult
            // 
            this.gridTrainingesult.AllowUserToAddRows = false;
            this.gridTrainingesult.AllowUserToOrderColumns = true;
            this.gridTrainingesult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridTrainingesult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridTrainingesult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridTrainingesult.BackgroundColor = System.Drawing.Color.White;
            this.gridTrainingesult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrainingesult.Location = new System.Drawing.Point(202, 379);
            this.gridTrainingesult.Name = "gridTrainingesult";
            this.gridTrainingesult.RowHeadersVisible = false;
            this.gridTrainingesult.Size = new System.Drawing.Size(977, 339);
            this.gridTrainingesult.TabIndex = 1;
            this.gridTrainingesult.Text = "dataGridView1";
            this.gridTrainingesult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTrainingesult_CellClick);
            // 
            // AdminEditTrainingViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 749);
            this.Controls.Add(this.gridTrainingesult);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.inputDepartment);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.entryTextLabel);
            this.Controls.Add(this.headlineEditTraining);
            this.Name = "AdminEditTrainingViewerForm";
            this.Text = "AdminEditTrainingViewerForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainingesult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headlineEditTraining;
        private System.Windows.Forms.TextBox entryTextLabel;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.ComboBox inputDepartment;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.DataGridView gridTrainingesult;
    }
}