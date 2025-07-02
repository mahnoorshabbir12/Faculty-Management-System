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
    public partial class FacultyCoursesCrud : Form
    {
        public FacultyCoursesCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = FacultyCoursesDL.GetAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckInteger(textBox9.Text, "Faculty ID"))
                    return;

                int FacultyID = int.Parse(textBox9.Text);
                if (!ValiationFunc.CheckNumber(FacultyID, "Faculty ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox7.Text, "Course ID"))
                    return;

                int CourseID = int.Parse(textBox7.Text);
                if (!ValiationFunc.CheckNumber(CourseID, "Course ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Semester ID"))
                    return;

                int SemesterID = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(SemesterID, "Semester ID"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox1.Text, "Faculty Course ID"))
                        return;

                    int FacultyCourseID = int.Parse(textBox1.Text);
                    if (!ValiationFunc.CheckNumber(FacultyCourseID, "Faculty Course ID"))
                        return;

                    FacultyCoursesBL facultyCourse = new FacultyCoursesBL(FacultyCourseID, FacultyID, CourseID, SemesterID);
                    FacultyCoursesDL.AddFacultyCourse(facultyCourse);
                }
                else
                {
                    FacultyCoursesBL facultyCourse = new FacultyCoursesBL(FacultyID, CourseID, SemesterID);
                    FacultyCoursesDL.AddFacultyCourseWithoutID(facultyCourse);
                }

                dataGridView1.DataSource = FacultyCoursesDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Faculty Course ID"))
                    return;

                int FacultyCourseID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(FacultyCourseID, "Faculty Course ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox9.Text, "Faculty ID"))
                    return;

                int FacultyID = int.Parse(textBox9.Text);
                if (!ValiationFunc.CheckNumber(FacultyID, "Faculty ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox7.Text, "Course ID"))
                    return;

                int CourseID = int.Parse(textBox7.Text);
                if (!ValiationFunc.CheckNumber(CourseID, "Course ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Semester ID"))
                    return;

                int SemesterID = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(SemesterID, "Semester ID"))
                    return;

                FacultyCoursesBL facultyCourse = new FacultyCoursesBL(FacultyCourseID, FacultyID, CourseID, SemesterID);
                FacultyCoursesDL.UpdateFacultyCourse(facultyCourse);
                dataGridView1.DataSource = FacultyCoursesDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Faculty Course ID"))
                    return;

                int ID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ID, "Faculty Course ID"))
                    return;

                FacultyCoursesDL.DeleteFacultyCourse(ID);
                dataGridView1.DataSource = FacultyCoursesDL.GetAll();
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