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

namespace WindowsFormsApp1.UI.DepartmentHead
{
    public partial class HeadDasboard : Form
    {
        public HeadDasboard()
        {
            InitializeComponent();
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            FacultyAdminRoleCrud facultyAdminRoleCrud = new FacultyAdminRoleCrud();
            this.Hide();
            facultyAdminRoleCrud.Show();
        }

        private void guna2GradientCircleButton2_Click_1(object sender, EventArgs e)
        {
            FacultyCoursesCrud newform = new FacultyCoursesCrud();
            this.Hide();
            newform.Show();
        }

        private void guna2GradientCircleButton6_Click(object sender, EventArgs e)
        {
            FacultyProjectsCrud newform = new FacultyProjectsCrud();
            this.Hide();
            newform.Show();
        }

        private void guna2GradientCircleButton4_Click(object sender, EventArgs e)
        {
            UpdateRequestStatus newForm = new UpdateRequestStatus();
            this.Hide();
            newForm.Show();
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
            FacultyRoomAllocationsCrud newform = new FacultyRoomAllocationsCrud();
            this.Hide();
            newform.Show();
        }
    }
}
