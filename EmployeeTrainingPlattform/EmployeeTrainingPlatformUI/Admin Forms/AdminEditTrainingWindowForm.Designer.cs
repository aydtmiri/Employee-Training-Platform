namespace EmployeeTrainingPlatformUI.Admin_Forms
{
    partial class AdminEditTrainingWindowForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.inputPrerequisite = new System.Windows.Forms.TextBox();
            this.inputDepartment = new System.Windows.Forms.ComboBox();
            this.prerequisiteLabel = new System.Windows.Forms.Label();
            this.departmenrLabel = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.outputPrerequisite = new System.Windows.Forms.ListBox();
            this.btnUpdateTraining = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(247, 750);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(275, 750);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "/600 Characters";
            // 
            // inputDescription
            // 
            this.inputDescription.BackColor = System.Drawing.Color.White;
            this.inputDescription.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputDescription.Location = new System.Drawing.Point(247, 514);
            this.inputDescription.MaxLength = 600;
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(1044, 233);
            this.inputDescription.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.descriptionLabel.Location = new System.Drawing.Point(71, 506);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(117, 30);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // inputPrerequisite
            // 
            this.inputPrerequisite.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputPrerequisite.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputPrerequisite.Location = new System.Drawing.Point(247, 282);
            this.inputPrerequisite.Name = "inputPrerequisite";
            this.inputPrerequisite.Size = new System.Drawing.Size(977, 35);
            this.inputPrerequisite.TabIndex = 1;
            this.inputPrerequisite.TextChanged += new System.EventHandler(this.inputPrerequisite_TextChanged);
            // 
            // inputDepartment
            // 
            this.inputDepartment.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputDepartment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDepartment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputDepartment.FormattingEnabled = true;
            this.inputDepartment.Location = new System.Drawing.Point(247, 208);
            this.inputDepartment.Name = "inputDepartment";
            this.inputDepartment.Size = new System.Drawing.Size(214, 38);
            this.inputDepartment.TabIndex = 2;
            this.inputDepartment.SelectedIndexChanged += new System.EventHandler(this.inputDepartment_SelectedIndexChanged);
            // 
            // prerequisiteLabel
            // 
            this.prerequisiteLabel.AutoSize = true;
            this.prerequisiteLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prerequisiteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.prerequisiteLabel.Location = new System.Drawing.Point(71, 285);
            this.prerequisiteLabel.Name = "prerequisiteLabel";
            this.prerequisiteLabel.Size = new System.Drawing.Size(127, 30);
            this.prerequisiteLabel.TabIndex = 0;
            this.prerequisiteLabel.Text = "Prerequisite:";
            // 
            // departmenrLabel
            // 
            this.departmenrLabel.AutoSize = true;
            this.departmenrLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmenrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.departmenrLabel.Location = new System.Drawing.Point(71, 211);
            this.departmenrLabel.Name = "departmenrLabel";
            this.departmenrLabel.Size = new System.Drawing.Size(129, 30);
            this.departmenrLabel.TabIndex = 0;
            this.departmenrLabel.Text = "Department:";
            // 
            // inputTitle
            // 
            this.inputTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputTitle.Location = new System.Drawing.Point(247, 134);
            this.inputTitle.MaxLength = 100;
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(977, 35);
            this.inputTitle.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.titleLabel.Location = new System.Drawing.Point(71, 140);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(57, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // outputPrerequisite
            // 
            this.outputPrerequisite.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputPrerequisite.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.outputPrerequisite.FormattingEnabled = true;
            this.outputPrerequisite.ItemHeight = 30;
            this.outputPrerequisite.Location = new System.Drawing.Point(247, 342);
            this.outputPrerequisite.Name = "outputPrerequisite";
            this.outputPrerequisite.Size = new System.Drawing.Size(977, 154);
            this.outputPrerequisite.TabIndex = 2;
            this.outputPrerequisite.SelectedIndexChanged += new System.EventHandler(this.outputPrerequisite_SelectedIndexChanged);
            // 
            // btnUpdateTraining
            // 
            this.btnUpdateTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.btnUpdateTraining.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateTraining.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateTraining.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdateTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTraining.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateTraining.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTraining.Location = new System.Drawing.Point(642, 821);
            this.btnUpdateTraining.Name = "btnUpdateTraining";
            this.btnUpdateTraining.Size = new System.Drawing.Size(211, 55);
            this.btnUpdateTraining.TabIndex = 3;
            this.btnUpdateTraining.Text = "Update Training";
            this.btnUpdateTraining.UseVisualStyleBackColor = false;
            this.btnUpdateTraining.Click += new System.EventHandler(this.btnUpdateTraining_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(614, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 50);
            this.label7.TabIndex = 0;
            this.label7.Text = "Update Training";
            // 
            // AdminEditTrainingWindowForm
            // 
            this.AcceptButton = this.btnUpdateTraining;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 956);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdateTraining);
            this.Controls.Add(this.outputPrerequisite);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.departmenrLabel);
            this.Controls.Add(this.prerequisiteLabel);
            this.Controls.Add(this.inputDepartment);
            this.Controls.Add(this.inputPrerequisite);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminEditTrainingWindowForm";
            this.Text = "Update Training";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox inputPrerequisite;
        private System.Windows.Forms.ComboBox inputDepartment;
        private System.Windows.Forms.Label prerequisiteLabel;
        private System.Windows.Forms.Label departmenrLabel;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox outputPrerequisite;
        private System.Windows.Forms.Button btnUpdateTraining;
        private System.Windows.Forms.Label label7;
    }
}