namespace WindowsFormsApp1.UI.FacultyMember
{
    partial class FacultyProjectsView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FacultyProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupervisionHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacultyProjectID,
            this.FacultyID,
            this.ProjectID,
            this.SemesterID,
            this.SupervisionHours});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // FacultyProjectID
            // 
            this.FacultyProjectID.DataPropertyName = "FacultyProjectID";
            this.FacultyProjectID.HeaderText = "FacultyProjectID";
            this.FacultyProjectID.MinimumWidth = 6;
            this.FacultyProjectID.Name = "FacultyProjectID";
            this.FacultyProjectID.Width = 125;
            // 
            // FacultyID
            // 
            this.FacultyID.DataPropertyName = "FacultyID";
            this.FacultyID.HeaderText = "FacultyID";
            this.FacultyID.MinimumWidth = 6;
            this.FacultyID.Name = "FacultyID";
            this.FacultyID.Width = 125;
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "ProjectID";
            this.ProjectID.HeaderText = "ProjectID";
            this.ProjectID.MinimumWidth = 6;
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Width = 125;
            // 
            // SemesterID
            // 
            this.SemesterID.DataPropertyName = "SemesterID";
            this.SemesterID.HeaderText = "SemesterID";
            this.SemesterID.MinimumWidth = 6;
            this.SemesterID.Name = "SemesterID";
            this.SemesterID.Width = 125;
            // 
            // SupervisionHours
            // 
            this.SupervisionHours.DataPropertyName = "SupervisionHours";
            this.SupervisionHours.HeaderText = "SupervisionHours";
            this.SupervisionHours.MinimumWidth = 6;
            this.SupervisionHours.Name = "SupervisionHours";
            this.SupervisionHours.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2GradientButton4);
            this.panel1.Location = new System.Drawing.Point(579, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 60);
            this.panel1.TabIndex = 2;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.Location = new System.Drawing.Point(3, 3);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(191, 54);
            this.guna2GradientButton4.TabIndex = 4;
            this.guna2GradientButton4.Text = "Go Back";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // FacultyProjectsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FacultyProjectsView";
            this.Text = "FacultyProjectsView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemesterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupervisionHours;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
    }
}