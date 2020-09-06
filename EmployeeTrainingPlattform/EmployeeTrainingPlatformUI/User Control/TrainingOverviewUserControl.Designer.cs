namespace EmployeeTrainingPlatformUI.User_Control
{
    partial class TrainingOverviewUserControl
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
            this.requiremntLabel = new System.Windows.Forms.Label();
            this.departmentValue = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.selectedTrainingValue = new System.Windows.Forms.Label();
            this.selectedTrainingLabel = new System.Windows.Forms.Label();
            this.descriptionValue = new System.Windows.Forms.TextBox();
            this.inputRequirement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trainingOverviewLabelö = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // requiremntLabel
            // 
            this.requiremntLabel.AutoSize = true;
            this.requiremntLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.requiremntLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.requiremntLabel.Location = new System.Drawing.Point(29, 138);
            this.requiremntLabel.Name = "requiremntLabel";
            this.requiremntLabel.Size = new System.Drawing.Size(127, 30);
            this.requiremntLabel.TabIndex = 0;
            this.requiremntLabel.Text = "Prerequisite:";
            // 
            // departmentValue
            // 
            this.departmentValue.AutoSize = true;
            this.departmentValue.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.departmentValue.Location = new System.Drawing.Point(228, 75);
            this.departmentValue.Name = "departmentValue";
            this.departmentValue.Size = new System.Drawing.Size(88, 30);
            this.departmentValue.TabIndex = 0;
            this.departmentValue.Text = "<none>";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.departmentLabel.Location = new System.Drawing.Point(29, 75);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(129, 30);
            this.departmentLabel.TabIndex = 0;
            this.departmentLabel.Text = "Department:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.descriptionLabel.Location = new System.Drawing.Point(29, 194);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(122, 30);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description:";
            // 
            // selectedTrainingValue
            // 
            this.selectedTrainingValue.AutoSize = true;
            this.selectedTrainingValue.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedTrainingValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectedTrainingValue.Location = new System.Drawing.Point(228, 19);
            this.selectedTrainingValue.Name = "selectedTrainingValue";
            this.selectedTrainingValue.Size = new System.Drawing.Size(88, 30);
            this.selectedTrainingValue.TabIndex = 0;
            this.selectedTrainingValue.Text = "<none>";
            // 
            // selectedTrainingLabel
            // 
            this.selectedTrainingLabel.AutoSize = true;
            this.selectedTrainingLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedTrainingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.selectedTrainingLabel.Location = new System.Drawing.Point(29, 19);
            this.selectedTrainingLabel.Name = "selectedTrainingLabel";
            this.selectedTrainingLabel.Size = new System.Drawing.Size(175, 30);
            this.selectedTrainingLabel.TabIndex = 0;
            this.selectedTrainingLabel.Text = "Selected Training:";
            // 
            // descriptionValue
            // 
            this.descriptionValue.BackColor = System.Drawing.SystemColors.MenuBar;
            this.descriptionValue.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.descriptionValue.Location = new System.Drawing.Point(211, 220);
            this.descriptionValue.Multiline = true;
            this.descriptionValue.Name = "descriptionValue";
            this.descriptionValue.ReadOnly = true;
            this.descriptionValue.Size = new System.Drawing.Size(909, 233);
            this.descriptionValue.TabIndex = 1;
            // 
            // inputRequirement
            // 
            this.inputRequirement.AutoSize = true;
            this.inputRequirement.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.inputRequirement.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.inputRequirement.Location = new System.Drawing.Point(228, 138);
            this.inputRequirement.Name = "inputRequirement";
            this.inputRequirement.Size = new System.Drawing.Size(88, 30);
            this.inputRequirement.TabIndex = 0;
            this.inputRequirement.Text = "<none>";
            this.inputRequirement.Click += new System.EventHandler(this.inputRequirement_Click);
            this.inputRequirement.MouseLeave += new System.EventHandler(this.inputRequirement_MouseLeave);
            this.inputRequirement.MouseHover += new System.EventHandler(this.inputRequirement_MouseHover);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.inputRequirement);
            this.panel1.Controls.Add(this.descriptionValue);
            this.panel1.Controls.Add(this.selectedTrainingLabel);
            this.panel1.Controls.Add(this.selectedTrainingValue);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.departmentLabel);
            this.panel1.Controls.Add(this.departmentValue);
            this.panel1.Controls.Add(this.requiremntLabel);
            this.panel1.Location = new System.Drawing.Point(14, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 463);
            this.panel1.TabIndex = 4;
            // 
            // trainingOverviewLabelö
            // 
            this.trainingOverviewLabelö.AutoSize = true;
            this.trainingOverviewLabelö.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainingOverviewLabelö.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trainingOverviewLabelö.Location = new System.Drawing.Point(13, 16);
            this.trainingOverviewLabelö.Name = "trainingOverviewLabelö";
            this.trainingOverviewLabelö.Size = new System.Drawing.Size(205, 32);
            this.trainingOverviewLabelö.TabIndex = 3;
            this.trainingOverviewLabelö.Text = "Training Overview";
            // 
            // TrainingOverviewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.trainingOverviewLabelö);
            this.Controls.Add(this.panel1);
            this.Name = "TrainingOverviewUserControl";
            this.Size = new System.Drawing.Size(1156, 516);
            this.Load += new System.EventHandler(this.TrainingOverviewUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label requiremntLabel;
        private System.Windows.Forms.Label departmentValue;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label selectedTrainingValue;
        private System.Windows.Forms.Label selectedTrainingLabel;
        private System.Windows.Forms.TextBox descriptionValue;
        private System.Windows.Forms.Label inputRequirement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label trainingOverviewLabelö;
    }
}
