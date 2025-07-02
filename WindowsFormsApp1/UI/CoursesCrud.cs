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
    public partial class CoursesCrud : Form
    {
        public CoursesCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = CourseDL.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(textBox9.Text, "Course Name"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Course Type"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Credit Hours"))
                    return;

                int CreditHours = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(CreditHours, "Credit Hours"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox4.Text, "Contact Hours"))
                    return;

                int ContactHours = int.Parse(textBox4.Text);
                if (!ValiationFunc.CheckNumber(ContactHours, "Contact Hours"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox1.Text, "Course ID"))
                        return;

                    int CourseID = int.Parse(textBox1.Text);
                    if (!ValiationFunc.CheckNumber(CourseID, "Course ID"))
                        return;

                    string CourseName = textBox9.Text;
                    string CourseType = textBox7.Text;

                    CourseBL C1 = new CourseBL(CourseID, CourseName, CourseType, CreditHours, ContactHours);
                    CourseDL.AddCourse(C1);
                }
                else
                {
                    string CourseName = textBox9.Text;
                    string CourseType = textBox7.Text;

                    CourseBL C1 = new CourseBL(CourseName, CourseType, CreditHours, ContactHours);
                    CourseDL.AddCourseWithoutID(C1);
                }

                dataGridView1.DataSource = CourseDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Course ID"))
                    return;

                int CourseID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(CourseID, "Course ID"))
                    return;

                if (!ValiationFunc.CheckString(textBox9.Text, "Course Name"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Course Type"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Credit Hours"))
                    return;

                int CreditHours = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(CreditHours, "Credit Hours"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox4.Text, "Contact Hours"))
                    return;

                int ContactHours = int.Parse(textBox4.Text);
                if (!ValiationFunc.CheckNumber(ContactHours, "Contact Hours"))
                    return;

                string CourseName = textBox9.Text;
                string CourseType = textBox7.Text;

                CourseBL C1 = new CourseBL(CourseID, CourseName, CourseType, CreditHours, ContactHours);
                CourseDL.UpdateCourse(C1);
                dataGridView1.DataSource = CourseDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Course ID"))
                    return;

                int ID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ID, "Course ID"))
                    return;

                CourseDL.DeleteCourse(ID);
                dataGridView1.DataSource = CourseDL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            UI.AdminStaff.Form10 form10 = new UI.AdminStaff.Form10();
            this.Hide();
            form10.Show();
        }
    }
}