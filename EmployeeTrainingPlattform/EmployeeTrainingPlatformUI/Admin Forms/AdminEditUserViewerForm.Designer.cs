namespace EmployeeTrainingPlatformUI.Admin_Forms
{
    partial class AdminEditUserViewerForm
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
            this.searchEmployeeLabel = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputDepartment = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.entryTextBox = new System.Windows.Forms.TextBox();
            this.gridEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // searchEmployeeLabel
            // 
            this.searchEmployeeLabel.AutoSize = true;
            this.searchEmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchEmployeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchEmployeeLabel.Location = new System.Drawing.Point(14, 275);
            this.searchEmployeeLabel.Name = "searchEmployeeLabel";
            this.searchEmployeeLabel.Size = new System.Drawing.Size(197, 32);
            this.searchEmployeeLabel.TabIndex = 3;
            this.searchEmployeeLabel.Text = "Search Employee";
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputName.Location = new System.Drawing.Point(180, 325);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(503, 35);
            this.inputName.TabIndex = 1;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // inputDepartment
            // 
            this.inputDepartment.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputDepartment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDepartment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputDepartment.FormattingEnabled = true;
            this.inputDepartment.Location = new System.Drawing.Point(180, 380);
            this.inputDepartment.Name = "inputDepartment";
            this.inputDepartment.Size = new System.Drawing.Size(214, 38);
            this.inputDepartment.TabIndex = 2;
            this.inputDepartment.SelectedIndexChanged += new System.EventHandler(this.inputDepartment_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.nameLabel.Location = new System.Drawing.Point(33, 325);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(73, 30);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepartmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.DepartmentLabel.Location = new System.Drawing.Point(33, 388);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(129, 30);
            this.DepartmentLabel.TabIndex = 0;
            this.DepartmentLabel.Text = "Department:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.headerLabel.Location = new System.Drawing.Point(629, 22);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(245, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Edit Employee";
            // 
            // entryTextBox
            // 
            this.entryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.entryTextBox.BackColor = System.Drawing.Color.White;
            this.entryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entryTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.entryTextBox.Location = new System.Drawing.Point(14, 144);
            this.entryTextBox.Multiline = true;
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.ReadOnly = true;
            this.entryTextBox.Size = new System.Drawing.Size(1141, 115);
            this.entryTextBox.TabIndex = 2;
            this.entryTextBox.Text = "<none>";
            // 
            // gridEmployee
            // 
            this.gridEmployee.AllowUserToAddRows = false;
            this.gridEmployee.AllowUserToOrderColumns = true;
            this.gridEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridEmployee.BackgroundColor = System.Drawing.Color.White;
            this.gridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployee.Location = new System.Drawing.Point(33, 486);
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.RowHeadersVisible = false;
            this.gridEmployee.Size = new System.Drawing.Size(1251, 406);
            this.gridEmployee.TabIndex = 1;
            this.gridEmployee.Text = "dataGridView1";
            this.gridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmployee_CellClick);
            // 
            // AdminEditUserViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 895);
            this.Controls.Add(this.gridEmployee);
            this.Controls.Add(this.entryTextBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inputDepartment);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.searchEmployeeLabel);
            this.Name = "AdminEditUserViewerForm";
            this.Text = "AdminEditUserViewerForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchEmployeeLabel;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.ComboBox inputDepartment;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox entryTextBox;
        private System.Windows.Forms.DataGridView gridEmployee;
    }
}