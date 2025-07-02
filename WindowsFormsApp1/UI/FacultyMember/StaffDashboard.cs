using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UI.FacultyMember
{
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            FacultyCourseView courseView = new FacultyCourseView();
            this.Hide();
            courseView.Show();
        }

        private void guna2GradientCircleButton7_Click(object sender, EventArgs e)
        {
            FacultyRequestsCrud facultyRequestsCrud = new FacultyRequestsCrud();
            this.Hide();
            facultyRequestsCrud.Show();
        }

        private void guna2GradientCircleButton6_Click(object sender, EventArgs e)
        {
            AdminCourseScheduleView courseScheduleView = new AdminCourseScheduleView();
            this.Hide();
            courseScheduleView.Show();
        }

        private void guna2GradientCircleButton5_Click(object sender, EventArgs e)
        {
            FacultyProjectsView facultyProjectsView = new FacultyProjectsView();
            this.Hide();
            facultyProjectsView.Show();
        }

        private void guna2GradientCircleButton4_Click(object sender, EventArgs e)
        {
            FacultyRoomsAllocationView faculty = new FacultyRoomsAllocationView();
            this.Hide();
            faculty.Show();
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
            FacultyCourseView faculty = new FacultyCourseView();
            this.Hide();
            faculty.Show();
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            this.Hide();
            reportForm.Show();
        }
    }
}
