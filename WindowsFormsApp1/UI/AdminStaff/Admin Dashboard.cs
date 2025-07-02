using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DL;
using WindowsFormsApp1.UI;

namespace WindowsFormsApp1.UI.AdminStaff
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            FacultyCrud newform = new FacultyCrud();
            this.Hide();
            newform.Show();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            AdminCourseScheduleCrud newForm = new AdminCourseScheduleCrud();
            this.Hide();
            newForm.Show();
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
            ProjectsCrud newform = new ProjectsCrud();
            this.Hide();
            newform.Show();
        }

        private void guna2GradientCircleButton4_Click(object sender, EventArgs e)
        {
            ApprovedRequestsView approvedRequestsView = new ApprovedRequestsView();
            this.Hide();
            approvedRequestsView.Show();
        }

        private void guna2GradientCircleButton6_Click(object sender, EventArgs e)
        {
            RoomsCrud newform = new RoomsCrud();
            this.Hide();
            newform.Show();
        }

        private void guna2GradientCircleButton5_Click(object sender, EventArgs e)
        {
            SemestersCrud newform = new SemestersCrud();
            this.Hide();
            newform.Show();
        }

        private void guna2GradientCircleButton7_Click(object sender, EventArgs e)
        {
            CoursesCrud newform = new CoursesCrud();
            this.Hide();
            newform.Show();
        }

        private void guna2GradientCircleButton8_Click(object sender, EventArgs e)
        {
            UserCrud newform = new UserCrud();
            this.Hide();
            newform.Show();
        }

        private void guna2GradientCircleButton9_Click(object sender, EventArgs e)
        {
            Reports.CourseForm courseForm = new Reports.CourseForm();
            this.Hide();
            courseForm.Show();
        }
    }
}
