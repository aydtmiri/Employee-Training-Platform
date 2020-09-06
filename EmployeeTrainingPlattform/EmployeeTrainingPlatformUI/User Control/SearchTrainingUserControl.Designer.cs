namespace EmployeeTrainingPlatformUI
{
    public partial class SearchTrainingUserControl
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
            this.inputDepartment = new System.Windows.Forms.ComboBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.trainingTitleLabel = new System.Windows.Forms.Label();
            this.outputTrainingResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputDepartment
            // 
            this.inputDepartment.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputDepartment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDepartment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputDepartment.FormattingEnabled = true;
            this.inputDepartment.Location = new System.Drawing.Point(183, 120);
            this.inputDepartment.Name = "inputDepartment";
            this.inputDepartment.Size = new System.Drawing.Size(214, 38);
            this.inputDepartment.TabIndex = 2;
            this.inputDepartment.SelectedIndexChanged += new System.EventHandler(this.inputDepartment_SelectedIndexChanged);
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.departmentLabel.Location = new System.Drawing.Point(36, 128);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(129, 30);
            this.departmentLabel.TabIndex = 0;
            this.departmentLabel.Text = "Department:";
            // 
            // inputTitle
            // 
            this.inputTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputTitle.Location = new System.Drawing.Point(183, 65);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(977, 35);
            this.inputTitle.TabIndex = 1;
            this.inputTitle.TextChanged += new System.EventHandler(this.inputTitle_TextChanged);
            // 
            // trainingTitleLabel
            // 
            this.trainingTitleLabel.AutoSize = true;
            this.trainingTitleLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainingTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.trainingTitleLabel.Location = new System.Drawing.Point(36, 65);
            this.trainingTitleLabel.Name = "trainingTitleLabel";
            this.trainingTitleLabel.Size = new System.Drawing.Size(57, 30);
            this.trainingTitleLabel.TabIndex = 0;
            this.trainingTitleLabel.Text = "Title:";
            // 
            // outputTrainingResult
            // 
            this.outputTrainingResult.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputTrainingResult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.outputTrainingResult.FormattingEnabled = true;
            this.outputTrainingResult.ItemHeight = 30;
            this.outputTrainingResult.Location = new System.Drawing.Point(183, 192);
            this.outputTrainingResult.Name = "outputTrainingResult";
            this.outputTrainingResult.Size = new System.Drawing.Size(977, 184);
            this.outputTrainingResult.TabIndex = 2;
            this.outputTrainingResult.SelectedIndexChanged += new System.EventHandler(this.outputTrainingResult_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Training";
            // 
            // SearchTrainingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainingTitleLabel);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.outputTrainingResult);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.inputDepartment);
            this.Name = "SearchTrainingUserControl";
            this.Size = new System.Drawing.Size(1244, 387);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inputDepartment;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.Label trainingTitleLabel;
        private System.Windows.Forms.ListBox outputTrainingResult;
        private System.Windows.Forms.Label label1;
    }
}
