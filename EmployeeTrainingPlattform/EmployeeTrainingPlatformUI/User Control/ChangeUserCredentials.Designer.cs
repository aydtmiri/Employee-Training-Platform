namespace EmployeeTrainingPlatformUI.User_Control
{
    partial class ChangeUserCredentials
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
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.label3emailAddressLabel = new System.Windows.Forms.Label();
            this.inputNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputOldPassword = new System.Windows.Forms.TextBox();
            this.inputEmailAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.newPasswordLabel.Location = new System.Drawing.Point(3, 114);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(151, 30);
            this.newPasswordLabel.TabIndex = 0;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oldPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.oldPasswordLabel.Location = new System.Drawing.Point(4, 68);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(179, 30);
            this.oldPasswordLabel.TabIndex = 0;
            this.oldPasswordLabel.Text = "Current Password:";
            // 
            // label3emailAddressLabel
            // 
            this.label3emailAddressLabel.AutoSize = true;
            this.label3emailAddressLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3emailAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.label3emailAddressLabel.Location = new System.Drawing.Point(4, 3);
            this.label3emailAddressLabel.Name = "label3emailAddressLabel";
            this.label3emailAddressLabel.Size = new System.Drawing.Size(149, 30);
            this.label3emailAddressLabel.TabIndex = 0;
            this.label3emailAddressLabel.Text = "Email-Address:";
            // 
            // inputNewPassword
            // 
            this.inputNewPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNewPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputNewPassword.Location = new System.Drawing.Point(190, 114);
            this.inputNewPassword.Name = "inputNewPassword";
            this.inputNewPassword.Size = new System.Drawing.Size(503, 35);
            this.inputNewPassword.TabIndex = 1;
            this.inputNewPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // inputOldPassword
            // 
            this.inputOldPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputOldPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputOldPassword.Location = new System.Drawing.Point(190, 68);
            this.inputOldPassword.Name = "inputOldPassword";
            this.inputOldPassword.Size = new System.Drawing.Size(503, 35);
            this.inputOldPassword.TabIndex = 1;
            this.inputOldPassword.UseSystemPasswordChar = true;
            // 
            // inputEmailAddress
            // 
            this.inputEmailAddress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputEmailAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputEmailAddress.Location = new System.Drawing.Point(190, 0);
            this.inputEmailAddress.Name = "inputEmailAddress";
            this.inputEmailAddress.Size = new System.Drawing.Size(503, 35);
            this.inputEmailAddress.TabIndex = 1;
            // 
            // ChangeUserCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.inputEmailAddress);
            this.Controls.Add(this.label3emailAddressLabel);
            this.Controls.Add(this.oldPasswordLabel);
            this.Controls.Add(this.inputOldPassword);
            this.Controls.Add(this.inputNewPassword);
            this.Controls.Add(this.newPasswordLabel);
            this.Name = "ChangeUserCredentials";
            this.Size = new System.Drawing.Size(704, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.Label label3emailAddressLabel;
        private System.Windows.Forms.TextBox inputNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputOldPassword;
        private System.Windows.Forms.TextBox inputEmailAddress;
    }
}
