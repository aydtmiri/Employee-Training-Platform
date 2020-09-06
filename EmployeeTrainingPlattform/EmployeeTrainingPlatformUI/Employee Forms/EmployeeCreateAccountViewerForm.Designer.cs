namespace EmployeeTrainingPlatformUI
{
    partial class EmployeeCreateAccountViewerForm
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
            this.headlineLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.inputDepartment = new System.Windows.Forms.ComboBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.inputEmailAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.headlineLabel.Location = new System.Drawing.Point(381, 32);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(260, 50);
            this.headlineLabel.TabIndex = 0;
            this.headlineLabel.Text = "Create Account";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.firstNameLabel.Location = new System.Drawing.Point(125, 138);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(114, 30);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.lastNameLabel.Location = new System.Drawing.Point(125, 213);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(113, 30);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.passwordLabel.Location = new System.Drawing.Point(125, 450);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(104, 30);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password:";
            // 
            // inputFirstName
            // 
            this.inputFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputFirstName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputFirstName.Location = new System.Drawing.Point(288, 138);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(503, 35);
            this.inputFirstName.TabIndex = 1;
            this.inputFirstName.TextChanged += new System.EventHandler(this.inputFirstName_TextChanged);
            // 
            // inputLastName
            // 
            this.inputLastName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputLastName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputLastName.Location = new System.Drawing.Point(288, 213);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(503, 35);
            this.inputLastName.TabIndex = 1;
            // 
            // inputPassword
            // 
            this.inputPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputPassword.Location = new System.Drawing.Point(288, 445);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(503, 35);
            this.inputPassword.TabIndex = 1;
            this.inputPassword.UseSystemPasswordChar = true;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.departmentLabel.Location = new System.Drawing.Point(125, 286);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(129, 30);
            this.departmentLabel.TabIndex = 0;
            this.departmentLabel.Text = "Department:";
            // 
            // inputDepartment
            // 
            this.inputDepartment.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputDepartment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDepartment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputDepartment.FormattingEnabled = true;
            this.inputDepartment.Location = new System.Drawing.Point(288, 286);
            this.inputDepartment.Name = "inputDepartment";
            this.inputDepartment.Size = new System.Drawing.Size(214, 38);
            this.inputDepartment.TabIndex = 2;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.btnCreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(406, 539);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(211, 55);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.emailAddressLabel.Location = new System.Drawing.Point(125, 384);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(147, 30);
            this.emailAddressLabel.TabIndex = 0;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // inputEmailAddress
            // 
            this.inputEmailAddress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputEmailAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputEmailAddress.Location = new System.Drawing.Point(288, 381);
            this.inputEmailAddress.Name = "inputEmailAddress";
            this.inputEmailAddress.Size = new System.Drawing.Size(503, 35);
            this.inputEmailAddress.TabIndex = 1;
            // 
            // EmployeeCreateAccountViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 667);
            this.Controls.Add(this.inputEmailAddress);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.inputDepartment);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.inputFirstName);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.headlineLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "EmployeeCreateAccountViewerForm";
            this.Text = "Training Platform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox inputFirstName;
        private System.Windows.Forms.TextBox inputLastName;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.ComboBox inputDepartment;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox inputEmailAddress;
    }
}