﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1.UI
{
    public partial class AdminCourseScheduleView: Form
    {
        public AdminCourseScheduleView()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = AdminCourseScheduleDL.GetAll();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            UI.FacultyMember.StaffDashboard newform = new UI.FacultyMember.StaffDashboard();
            this.Hide();
            newform.Show();
        }
    }
}
