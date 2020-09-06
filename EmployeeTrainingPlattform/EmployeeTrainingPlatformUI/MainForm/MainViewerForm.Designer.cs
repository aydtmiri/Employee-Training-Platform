namespace EmployeeTrainingPlatformUI.MainForm
{
    partial class MainViewerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuEmployee = new System.Windows.Forms.Button();
            this.subMenuEditEmployee = new System.Windows.Forms.Button();
            this.menuTraining = new System.Windows.Forms.Button();
            this.trainingSubMenuePanel = new System.Windows.Forms.Panel();
            this.subMenuEditTraining = new System.Windows.Forms.Button();
            this.subMenuCreateTrainig = new System.Windows.Forms.Button();
            this.mainContainerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.subMenuTrainingPlan = new System.Windows.Forms.Button();
            this.subMenuEditTrainingPlan = new System.Windows.Forms.Button();
            this.subMenuBookTraining = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userSettingsSubMenuePanel = new System.Windows.Forms.Panel();
            this.subMenuChangeSettings = new System.Windows.Forms.Button();
            this.userSettingsMenuBar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.inputRole = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.trainingSubMenuePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.userSettingsSubMenuePanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(95, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 72);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.menuEmployee);
            this.flowLayoutPanel1.Controls.Add(this.subMenuEditEmployee);
            this.flowLayoutPanel1.Controls.Add(this.menuTraining);
            this.flowLayoutPanel1.Controls.Add(this.trainingSubMenuePanel);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 804);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // menuEmployee
            // 
            this.menuEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.menuEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuEmployee.FlatAppearance.BorderSize = 0;
            this.menuEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuEmployee.ForeColor = System.Drawing.Color.White;
            this.menuEmployee.Location = new System.Drawing.Point(0, 72);
            this.menuEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.menuEmployee.Name = "menuEmployee";
            this.menuEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuEmployee.Size = new System.Drawing.Size(200, 40);
            this.menuEmployee.TabIndex = 1;
            this.menuEmployee.Text = "Employees";
            this.menuEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuEmployee.UseVisualStyleBackColor = false;
            this.menuEmployee.Click += new System.EventHandler(this.menuEmployees_Click);
            // 
            // subMenuEditEmployee
            // 
            this.subMenuEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(163)))), ((int)(((byte)(248)))));
            this.subMenuEditEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuEditEmployee.FlatAppearance.BorderSize = 0;
            this.subMenuEditEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(165)))));
            this.subMenuEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenuEditEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subMenuEditEmployee.ForeColor = System.Drawing.Color.White;
            this.subMenuEditEmployee.Location = new System.Drawing.Point(0, 112);
            this.subMenuEditEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.subMenuEditEmployee.Name = "subMenuEditEmployee";
            this.subMenuEditEmployee.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.subMenuEditEmployee.Size = new System.Drawing.Size(200, 40);
            this.subMenuEditEmployee.TabIndex = 0;
            this.subMenuEditEmployee.Text = "Edit Employee";
            this.subMenuEditEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuEditEmployee.UseVisualStyleBackColor = false;
            this.subMenuEditEmployee.Click += new System.EventHandler(this.menuEditEmployee_Click);
            // 
            // menuTraining
            // 
            this.menuTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.menuTraining.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTraining.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuTraining.FlatAppearance.BorderSize = 0;
            this.menuTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuTraining.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuTraining.ForeColor = System.Drawing.Color.White;
            this.menuTraining.Location = new System.Drawing.Point(0, 152);
            this.menuTraining.Margin = new System.Windows.Forms.Padding(0);
            this.menuTraining.Name = "menuTraining";
            this.menuTraining.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuTraining.Size = new System.Drawing.Size(200, 40);
            this.menuTraining.TabIndex = 1;
            this.menuTraining.Text = "Training";
            this.menuTraining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuTraining.UseVisualStyleBackColor = false;
            this.menuTraining.Click += new System.EventHandler(this.menuTraining_Click);
            // 
            // trainingSubMenuePanel
            // 
            this.trainingSubMenuePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.trainingSubMenuePanel.Controls.Add(this.subMenuEditTraining);
            this.trainingSubMenuePanel.Controls.Add(this.subMenuCreateTrainig);
            this.trainingSubMenuePanel.Controls.Add(this.mainContainerPanel);
            this.trainingSubMenuePanel.Controls.Add(this.subMenuTrainingPlan);
            this.trainingSubMenuePanel.Controls.Add(this.subMenuEditTrainingPlan);
            this.trainingSubMenuePanel.Controls.Add(this.subMenuBookTraining);
            this.trainingSubMenuePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.trainingSubMenuePanel.Location = new System.Drawing.Point(0, 192);
            this.trainingSubMenuePanel.Margin = new System.Windows.Forms.Padding(0);
            this.trainingSubMenuePanel.Name = "trainingSubMenuePanel";
            this.trainingSubMenuePanel.Size = new System.Drawing.Size(200, 129);
            this.trainingSubMenuePanel.TabIndex = 2;
            // 
            // subMenuEditTraining
            // 
            this.subMenuEditTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(163)))), ((int)(((byte)(248)))));
            this.subMenuEditTraining.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuEditTraining.FlatAppearance.BorderSize = 0;
            this.subMenuEditTraining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(165)))));
            this.subMenuEditTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenuEditTraining.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subMenuEditTraining.ForeColor = System.Drawing.Color.White;
            this.subMenuEditTraining.Location = new System.Drawing.Point(0, 160);
            this.subMenuEditTraining.Name = "subMenuEditTraining";
            this.subMenuEditTraining.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.subMenuEditTraining.Size = new System.Drawing.Size(200, 44);
            this.subMenuEditTraining.TabIndex = 0;
            this.subMenuEditTraining.Text = "Edit Training";
            this.subMenuEditTraining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuEditTraining.UseVisualStyleBackColor = false;
            this.subMenuEditTraining.Click += new System.EventHandler(this.subMenuEditTraining_Click);
            // 
            // subMenuCreateTrainig
            // 
            this.subMenuCreateTrainig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(163)))), ((int)(((byte)(248)))));
            this.subMenuCreateTrainig.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuCreateTrainig.FlatAppearance.BorderSize = 0;
            this.subMenuCreateTrainig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(165)))));
            this.subMenuCreateTrainig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenuCreateTrainig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subMenuCreateTrainig.ForeColor = System.Drawing.Color.White;
            this.subMenuCreateTrainig.Location = new System.Drawing.Point(0, 120);
            this.subMenuCreateTrainig.Name = "subMenuCreateTrainig";
            this.subMenuCreateTrainig.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.subMenuCreateTrainig.Size = new System.Drawing.Size(200, 40);
            this.subMenuCreateTrainig.TabIndex = 0;
            this.subMenuCreateTrainig.Text = "Create Training";
            this.subMenuCreateTrainig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuCreateTrainig.UseVisualStyleBackColor = false;
            this.subMenuCreateTrainig.Click += new System.EventHandler(this.subMenuCreateTraining_Click);
            // 
            // mainContainerPanel
            // 
            this.mainContainerPanel.Location = new System.Drawing.Point(203, 31);
            this.mainContainerPanel.Name = "mainContainerPanel";
            this.mainContainerPanel.Size = new System.Drawing.Size(876, 500);
            this.mainContainerPanel.TabIndex = 4;
            // 
            // subMenuTrainingPlan
            // 
            this.subMenuTrainingPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(163)))), ((int)(((byte)(248)))));
            this.subMenuTrainingPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuTrainingPlan.FlatAppearance.BorderSize = 0;
            this.subMenuTrainingPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(165)))));
            this.subMenuTrainingPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenuTrainingPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subMenuTrainingPlan.ForeColor = System.Drawing.Color.White;
            this.subMenuTrainingPlan.Location = new System.Drawing.Point(0, 80);
            this.subMenuTrainingPlan.Name = "subMenuTrainingPlan";
            this.subMenuTrainingPlan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.subMenuTrainingPlan.Size = new System.Drawing.Size(200, 40);
            this.subMenuTrainingPlan.TabIndex = 0;
            this.subMenuTrainingPlan.Text = "Training Plan";
            this.subMenuTrainingPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuTrainingPlan.UseVisualStyleBackColor = false;
            this.subMenuTrainingPlan.Click += new System.EventHandler(this.subMenuTrainingPlan_Click);
            // 
            // subMenuEditTrainingPlan
            // 
            this.subMenuEditTrainingPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(163)))), ((int)(((byte)(248)))));
            this.subMenuEditTrainingPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuEditTrainingPlan.FlatAppearance.BorderSize = 0;
            this.subMenuEditTrainingPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(165)))));
            this.subMenuEditTrainingPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenuEditTrainingPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subMenuEditTrainingPlan.ForeColor = System.Drawing.Color.White;
            this.subMenuEditTrainingPlan.Location = new System.Drawing.Point(0, 40);
            this.subMenuEditTrainingPlan.Name = "subMenuEditTrainingPlan";
            this.subMenuEditTrainingPlan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.subMenuEditTrainingPlan.Size = new System.Drawing.Size(200, 40);
            this.subMenuEditTrainingPlan.TabIndex = 0;
            this.subMenuEditTrainingPlan.Text = "Edit Training Plan";
            this.subMenuEditTrainingPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuEditTrainingPlan.UseVisualStyleBackColor = false;
            this.subMenuEditTrainingPlan.Click += new System.EventHandler(this.subMenuEditTrainingPlan_Click);
            // 
            // subMenuBookTraining
            // 
            this.subMenuBookTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(163)))), ((int)(((byte)(248)))));
            this.subMenuBookTraining.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuBookTraining.FlatAppearance.BorderSize = 0;
            this.subMenuBookTraining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(165)))));
            this.subMenuBookTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenuBookTraining.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subMenuBookTraining.ForeColor = System.Drawing.Color.White;
            this.subMenuBookTraining.Location = new System.Drawing.Point(0, 0);
            this.subMenuBookTraining.Margin = new System.Windows.Forms.Padding(0);
            this.subMenuBookTraining.Name = "subMenuBookTraining";
            this.subMenuBookTraining.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.subMenuBookTraining.Size = new System.Drawing.Size(200, 40);
            this.subMenuBookTraining.TabIndex = 0;
            this.subMenuBookTraining.Text = "Book Training";
            this.subMenuBookTraining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuBookTraining.UseVisualStyleBackColor = false;
            this.subMenuBookTraining.Click += new System.EventHandler(this.subMenueBookTraining_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userSettingsSubMenuePanel);
            this.panel3.Controls.Add(this.userSettingsMenuBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 321);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 83);
            this.panel3.TabIndex = 3;
            // 
            // userSettingsSubMenuePanel
            // 
            this.userSettingsSubMenuePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.userSettingsSubMenuePanel.Controls.Add(this.subMenuChangeSettings);
            this.userSettingsSubMenuePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userSettingsSubMenuePanel.Location = new System.Drawing.Point(0, 40);
            this.userSettingsSubMenuePanel.Margin = new System.Windows.Forms.Padding(0);
            this.userSettingsSubMenuePanel.Name = "userSettingsSubMenuePanel";
            this.userSettingsSubMenuePanel.Size = new System.Drawing.Size(200, 155);
            this.userSettingsSubMenuePanel.TabIndex = 2;
            // 
            // subMenuChangeSettings
            // 
            this.subMenuChangeSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(163)))), ((int)(((byte)(248)))));
            this.subMenuChangeSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuChangeSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenuChangeSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subMenuChangeSettings.ForeColor = System.Drawing.Color.White;
            this.subMenuChangeSettings.Location = new System.Drawing.Point(0, 0);
            this.subMenuChangeSettings.Name = "subMenuChangeSettings";
            this.subMenuChangeSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.subMenuChangeSettings.Size = new System.Drawing.Size(200, 43);
            this.subMenuChangeSettings.TabIndex = 0;
            this.subMenuChangeSettings.Text = "Change Settings";
            this.subMenuChangeSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuChangeSettings.UseVisualStyleBackColor = false;
            this.subMenuChangeSettings.Click += new System.EventHandler(this.subMenueChangeSettings_Click);
            // 
            // userSettingsMenuBar
            // 
            this.userSettingsMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.userSettingsMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.userSettingsMenuBar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.userSettingsMenuBar.FlatAppearance.BorderSize = 0;
            this.userSettingsMenuBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userSettingsMenuBar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userSettingsMenuBar.ForeColor = System.Drawing.Color.White;
            this.userSettingsMenuBar.Location = new System.Drawing.Point(0, 0);
            this.userSettingsMenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.userSettingsMenuBar.Name = "userSettingsMenuBar";
            this.userSettingsMenuBar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.userSettingsMenuBar.Size = new System.Drawing.Size(200, 40);
            this.userSettingsMenuBar.TabIndex = 1;
            this.userSettingsMenuBar.Text = "User Settings";
            this.userSettingsMenuBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userSettingsMenuBar.UseVisualStyleBackColor = false;
            this.userSettingsMenuBar.Click += new System.EventHandler(this.userSettingsMenuBar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.panel5.Controls.Add(this.inputRole);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(206, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1356, 65);
            this.panel5.TabIndex = 4;
            // 
            // inputRole
            // 
            this.inputRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.inputRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputRole.ForeColor = System.Drawing.Color.White;
            this.inputRole.FormattingEnabled = true;
            this.inputRole.Items.AddRange(new object[] {
            "Administrator",
            "Employee"});
            this.inputRole.Location = new System.Drawing.Point(1072, 18);
            this.inputRole.Name = "inputRole";
            this.inputRole.Size = new System.Drawing.Size(155, 29);
            this.inputRole.TabIndex = 1;
            this.inputRole.SelectedIndexChanged += new System.EventHandler(this.inputRole_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1269, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.logOut_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(206, 65);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1356, 739);
            this.mainPanel.TabIndex = 5;
            // 
            // MainViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1562, 804);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainViewerForm";
            this.Text = "Training Platform";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.trainingSubMenuePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.userSettingsSubMenuePanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button menuTraining;
        private System.Windows.Forms.Panel trainingSubMenuePanel;
        private System.Windows.Forms.Button subMenuBookTraining;
        private System.Windows.Forms.Button subMenuEditTrainingPlan;
        private System.Windows.Forms.Button subMenuTrainingPlan;
        private System.Windows.Forms.FlowLayoutPanel mainContainerPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button subMenuCreateTrainig;
        private System.Windows.Forms.ComboBox inputRole;
        private System.Windows.Forms.Button menuEmployee;
        private System.Windows.Forms.Button subMenuEditEmployee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button userSettingsMenuBar;
        private System.Windows.Forms.Panel userSettingsSubMenuePanel;
        private System.Windows.Forms.Button subMenuChangeSettings;
        private System.Windows.Forms.Button subMenuEditTraining;
    }
}