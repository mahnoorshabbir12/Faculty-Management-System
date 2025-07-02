using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1.UI
{
    public partial class FacultyAdminRoleCrud : Form
    {
        public FacultyAdminRoleCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = FacultyAdminRoleDL.GetAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(textBox7.Text, "Role Name"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox9.Text, "Faculty ID"))
                    return;

                int FacultyID = int.Parse(textBox9.Text);
                if (!ValiationFunc.CheckNumber(FacultyID, "Faculty ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Semester ID"))
                    return;

                int SemesterID = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(SemesterID, "Semester ID"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox1.Text, "Admin Role ID"))
                        return;

                    int AdminRoleID = int.Parse(textBox1.Text);
                    if (!ValiationFunc.CheckNumber(AdminRoleID, "Admin Role ID"))
                        return;

                    string RoleName = textBox7.Text;

                    FacultyAdminRoleBL facultyAdminRole = new FacultyAdminRoleBL(AdminRoleID, FacultyID, RoleName, SemesterID);
                    FacultyAdminRoleDL.AddFacultyAdminRole(facultyAdminRole);
                }
                else
                {
                    string RoleName = textBox7.Text;

                    FacultyAdminRoleBL facultyAdminRole = new FacultyAdminRoleBL(FacultyID, RoleName, SemesterID);
                    FacultyAdminRoleDL.AddFacultyAdminRoleWithoutID(facultyAdminRole);
                }

                dataGridView1.DataSource = FacultyAdminRoleDL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Admin Role ID"))
                    return;

                int AdminRoleID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(AdminRoleID, "Admin Role ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox9.Text, "Faculty ID"))
                    return;

                int FacultyID = int.Parse(textBox9.Text);
                if (!ValiationFunc.CheckNumber(FacultyID, "Faculty ID"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Role Name"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Semester ID"))
                    return;

                int SemesterID = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(SemesterID, "Semester ID"))
                    return;

                string RoleName = textBox7.Text;

                FacultyAdminRoleBL facultyAdminRole = new FacultyAdminRoleBL(AdminRoleID, FacultyID, RoleName, SemesterID);
                FacultyAdminRoleDL.UpdateFacultyAdminRole(facultyAdminRole);
                dataGridView1.DataSource = FacultyAdminRoleDL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Admin Role ID"))
                    return;

                int ID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ID, "Admin Role ID"))
                    return;

                FacultyAdminRoleDL.DeleteFacultyAdminRole(ID);
                dataGridView1.DataSource = FacultyAdminRoleDL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            UI.DepartmentHead.HeadDasboard newform = new UI.DepartmentHead.HeadDasboard();
            this.Hide();
            newform.Show();
        }
    }
}