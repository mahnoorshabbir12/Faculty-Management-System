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
    public partial class FacultyProjectsCrud : Form
    {
        public FacultyProjectsCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = FacultyProjectsDL.GetAll();
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

                if (!ValiationFunc.CheckInteger(textBox7.Text, "Project ID"))
                    return;

                int ProjectID = int.Parse(textBox7.Text);
                if (!ValiationFunc.CheckNumber(ProjectID, "Project ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Semester ID"))
                    return;

                int SemesterID = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(SemesterID, "Semester ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox4.Text, "Supervision Hours"))
                    return;

                int SupervisionHours = int.Parse(textBox4.Text);
                if (!ValiationFunc.CheckNumber(SupervisionHours, "Supervision Hours"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox1.Text, "Faculty Project ID"))
                        return;

                    int FacultyProjectID = int.Parse(textBox1.Text);
                    if (!ValiationFunc.CheckNumber(FacultyProjectID, "Faculty Project ID"))
                        return;

                    FacultyProjectsBL project = new FacultyProjectsBL(FacultyProjectID, FacultyID, ProjectID, SemesterID, SupervisionHours);
                    FacultyProjectsDL.AddFacultyProject(project);
                }
                else
                {
                    FacultyProjectsBL project = new FacultyProjectsBL(FacultyID, ProjectID, SemesterID, SupervisionHours);
                    FacultyProjectsDL.AddFacultyProjectWithoutID(project);
                }

                dataGridView1.DataSource = FacultyProjectsDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Faculty Project ID"))
                    return;

                int FacultyProjectID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(FacultyProjectID, "Faculty Project ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox9.Text, "Faculty ID"))
                    return;

                int FacultyID = int.Parse(textBox9.Text);
                if (!ValiationFunc.CheckNumber(FacultyID, "Faculty ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox7.Text, "Project ID"))
                    return;

                int ProjectID = int.Parse(textBox7.Text);
                if (!ValiationFunc.CheckNumber(ProjectID, "Project ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Semester ID"))
                    return;

                int SemesterID = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(SemesterID, "Semester ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox4.Text, "Supervision Hours"))
                    return;

                int SupervisionHours = int.Parse(textBox4.Text);
                if (!ValiationFunc.CheckNumber(SupervisionHours, "Supervision Hours"))
                    return;

                FacultyProjectsBL project = new FacultyProjectsBL(FacultyProjectID, FacultyID, ProjectID, SemesterID, SupervisionHours);
                FacultyProjectsDL.UpdateFacultyProject(project);
                dataGridView1.DataSource = FacultyProjectsDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Faculty Project ID"))
                    return;

                int ID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ID, "Faculty Project ID"))
                    return;

                FacultyProjectsDL.DeleteFacultyProject(ID);
                dataGridView1.DataSource = FacultyProjectsDL.GetAll();
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