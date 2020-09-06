namespace EmployeeTrainingPlatformUI
{
    partial class AdminCreateTrainingViewerForm
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
            this.headlineCreateTraining = new System.Windows.Forms.Label();
            this.btnCreateTraining = new System.Windows.Forms.Button();
            this.outputRequirementResult = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.requirementLabel = new System.Windows.Forms.Label();
            this.inputDepartment = new System.Windows.Forms.ComboBox();
            this.inputRequirement = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.charactersLabel = new System.Windows.Forms.Label();
            this.charCounterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headlineCreateTraining
            // 
            this.headlineCreateTraining.AutoSize = true;
            this.headlineCreateTraining.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headlineCreateTraining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.headlineCreateTraining.Location = new System.Drawing.Point(581, 29);
            this.headlineCreateTraining.Name = "headlineCreateTraining";
            this.headlineCreateTraining.Size = new System.Drawing.Size(254, 50);
            this.headlineCreateTraining.TabIndex = 0;
            this.headlineCreateTraining.Text = "Create Training";
            // 
            // btnCreateTraining
            // 
            this.btnCreateTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.btnCreateTraining.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCreateTraining.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreateTraining.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTraining.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateTraining.ForeColor = System.Drawing.Color.White;
            this.btnCreateTraining.Location = new System.Drawing.Point(506, 848);
            this.btnCreateTraining.Name = "btnCreateTraining";
            this.btnCreateTraining.Size = new System.Drawing.Size(211, 55);
            this.btnCreateTraining.TabIndex = 3;
            this.btnCreateTraining.Text = "Create Training";
            this.btnCreateTraining.UseVisualStyleBackColor = false;
            this.btnCreateTraining.Click += new System.EventHandler(this.btnCreateTraining_Click);
            // 
            // outputRequirementResult
            // 
            this.outputRequirementResult.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputRequirementResult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.outputRequirementResult.FormattingEnabled = true;
            this.outputRequirementResult.ItemHeight = 30;
            this.outputRequirementResult.Location = new System.Drawing.Point(214, 363);
            this.outputRequirementResult.Name = "outputRequirementResult";
            this.outputRequirementResult.Size = new System.Drawing.Size(977, 154);
            this.outputRequirementResult.TabIndex = 2;
            this.outputRequirementResult.SelectedIndexChanged += new System.EventHandler(this.outputReequirementResult_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.titleLabel.Location = new System.Drawing.Point(38, 161);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(57, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // inputTitle
            // 
            this.inputTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputTitle.Location = new System.Drawing.Point(214, 155);
            this.inputTitle.MaxLength = 100;
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(977, 35);
            this.inputTitle.TabIndex = 1;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.departmentLabel.Location = new System.Drawing.Point(38, 232);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(129, 30);
            this.departmentLabel.TabIndex = 0;
            this.departmentLabel.Text = "Department:";
            // 
            // requirementLabel
            // 
            this.requirementLabel.AutoSize = true;
            this.requirementLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.requirementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.requirementLabel.Location = new System.Drawing.Point(38, 306);
            this.requirementLabel.Name = "requirementLabel";
            this.requirementLabel.Size = new System.Drawing.Size(127, 30);
            this.requirementLabel.TabIndex = 0;
            this.requirementLabel.Text = "Prerequisite:";
            // 
            // inputDepartment
            // 
            this.inputDepartment.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputDepartment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDepartment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputDepartment.FormattingEnabled = true;
            this.inputDepartment.Location = new System.Drawing.Point(214, 229);
            this.inputDepartment.Name = "inputDepartment";
            this.inputDepartment.Size = new System.Drawing.Size(214, 38);
            this.inputDepartment.TabIndex = 2;
            this.inputDepartment.SelectedIndexChanged += new System.EventHandler(this.inputDepartment_SelectedIndexChanged);
            // 
            // inputRequirement
            // 
            this.inputRequirement.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputRequirement.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputRequirement.Location = new System.Drawing.Point(214, 303);
            this.inputRequirement.Name = "inputRequirement";
            this.inputRequirement.Size = new System.Drawing.Size(977, 35);
            this.inputRequirement.TabIndex = 1;
            this.inputRequirement.TextChanged += new System.EventHandler(this.inputRequirement_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.descriptionLabel.Location = new System.Drawing.Point(38, 527);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(117, 30);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // inputDescription
            // 
            this.inputDescription.BackColor = System.Drawing.Color.White;
            this.inputDescription.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputDescription.Location = new System.Drawing.Point(214, 535);
            this.inputDescription.MaxLength = 600;
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(1044, 233);
            this.inputDescription.TabIndex = 3;
            this.inputDescription.TextChanged += new System.EventHandler(this.inputDescription_TextChanged);
            // 
            // charactersLabel
            // 
            this.charactersLabel.AutoSize = true;
            this.charactersLabel.BackColor = System.Drawing.Color.Transparent;
            this.charactersLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charactersLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.charactersLabel.Location = new System.Drawing.Point(242, 771);
            this.charactersLabel.Name = "charactersLabel";
            this.charactersLabel.Size = new System.Drawing.Size(112, 20);
            this.charactersLabel.TabIndex = 4;
            this.charactersLabel.Text = "/600 Characters";
            // 
            // charCounterLabel
            // 
            this.charCounterLabel.AutoSize = true;
            this.charCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.charCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charCounterLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.charCounterLabel.Location = new System.Drawing.Point(214, 771);
            this.charCounterLabel.Name = "charCounterLabel";
            this.charCounterLabel.Size = new System.Drawing.Size(17, 20);
            this.charCounterLabel.TabIndex = 4;
            this.charCounterLabel.Text = "0";
            this.charCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdminCreateTrainingViewerForm
            // 
            this.AcceptButton = this.btnCreateTraining;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 996);
            this.Controls.Add(this.charCounterLabel);
            this.Controls.Add(this.charactersLabel);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.inputRequirement);
            this.Controls.Add(this.inputDepartment);
            this.Controls.Add(this.requirementLabel);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.outputRequirementResult);
            this.Controls.Add(this.btnCreateTraining);
            this.Controls.Add(this.headlineCreateTraining);
            this.Name = "AdminCreateTrainingViewerForm";
            this.Text = "AdminCreateTrainingViewerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headlineCreateTraining;
        private System.Windows.Forms.Button btnCreateTraining;
        private System.Windows.Forms.ListBox outputRequirementResult;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label requirementLabel;
        private System.Windows.Forms.ComboBox inputDepartment;
        private System.Windows.Forms.TextBox inputRequirement;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.Label charactersLabel;
        private System.Windows.Forms.Label charCounterLabel;
    }
}