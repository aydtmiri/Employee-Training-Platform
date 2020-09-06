namespace EmployeeTrainingPlatformUI
{
    partial class EmployeeBookTrainingViewerForm
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
            this.headlineCookTraining = new System.Windows.Forms.Label();
            this.btnBookTraining = new System.Windows.Forms.Button();
            this.trainingOverviewUserControl1 = new EmployeeTrainingPlatformUI.User_Control.TrainingOverviewUserControl();
            this.searchTrainingUserControl1 = new EmployeeTrainingPlatformUI.SearchTrainingUserControl();
            this.SuspendLayout();
            // 
            // headlineCookTraining
            // 
            this.headlineCookTraining.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headlineCookTraining.AutoSize = true;
            this.headlineCookTraining.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headlineCookTraining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.headlineCookTraining.Location = new System.Drawing.Point(571, 30);
            this.headlineCookTraining.Name = "headlineCookTraining";
            this.headlineCookTraining.Size = new System.Drawing.Size(231, 50);
            this.headlineCookTraining.TabIndex = 0;
            this.headlineCookTraining.Text = "Book Training";
            this.headlineCookTraining.Click += new System.EventHandler(this.headlineCookTraining_Click);
            // 
            // btnBookTraining
            // 
            this.btnBookTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(241)))));
            this.btnBookTraining.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnBookTraining.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBookTraining.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBookTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookTraining.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBookTraining.ForeColor = System.Drawing.Color.White;
            this.btnBookTraining.Location = new System.Drawing.Point(495, 1033);
            this.btnBookTraining.Name = "btnBookTraining";
            this.btnBookTraining.Size = new System.Drawing.Size(211, 55);
            this.btnBookTraining.TabIndex = 3;
            this.btnBookTraining.Text = "Book Training";
            this.btnBookTraining.UseVisualStyleBackColor = false;
            this.btnBookTraining.Click += new System.EventHandler(this.btnBookTraining_Click);
            // 
            // trainingOverviewUserControl1
            // 
            this.trainingOverviewUserControl1.BackColor = System.Drawing.Color.White;
            this.trainingOverviewUserControl1.Location = new System.Drawing.Point(18, 520);
            this.trainingOverviewUserControl1.Name = "trainingOverviewUserControl1";
            this.trainingOverviewUserControl1.OpenRequirement = null;
            this.trainingOverviewUserControl1.Size = new System.Drawing.Size(1172, 507);
            this.trainingOverviewUserControl1.TabIndex = 5;
            // 
            // searchTrainingUserControl1
            // 
            this.searchTrainingUserControl1.BackColor = System.Drawing.Color.White;
            this.searchTrainingUserControl1.DepartmentChanged = null;
            this.searchTrainingUserControl1.Location = new System.Drawing.Point(18, 138);
            this.searchTrainingUserControl1.Name = "searchTrainingUserControl1";
            this.searchTrainingUserControl1.Size = new System.Drawing.Size(1218, 387);
            this.searchTrainingUserControl1.TabIndex = 6;
            this.searchTrainingUserControl1.TitleChanged = null;
            this.searchTrainingUserControl1.TrainingSelected = null;
            // 
            // EmployeeBookTrainingViewerForm
            // 
            this.AcceptButton = this.btnBookTraining;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 1100);
            this.Controls.Add(this.searchTrainingUserControl1);
            this.Controls.Add(this.trainingOverviewUserControl1);
            this.Controls.Add(this.btnBookTraining);
            this.Controls.Add(this.headlineCookTraining);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeBookTrainingViewerForm";
            this.Text = "Book Training";
            this.Load += new System.EventHandler(this.EmployeeBookTrainingViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headlineCookTraining;
        private System.Windows.Forms.Button btnBookTraining;
      
        private User_Control.TrainingOverviewUserControl trainingOverviewUserControl1;
        private SearchTrainingUserControl searchTrainingUserControl1;
    }
}