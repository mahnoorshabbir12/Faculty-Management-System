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
    public partial class SemestersCrud : Form
    {
        public SemestersCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = SemestersDL.GetAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(textBox9.Text, "Term"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox7.Text, "Year"))
                    return;

                int Year = int.Parse(textBox7.Text);
                if (!ValiationFunc.CheckNumber(Year, "Year"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox1.Text, "Semester ID"))
                        return;

                    int SemesterID = int.Parse(textBox1.Text);
                    if (!ValiationFunc.CheckNumber(SemesterID, "Semester ID"))
                        return;

                    string Term = textBox9.Text;

                    SemestersBL semester = new SemestersBL(SemesterID, Term, Year);
                    SemestersDL.AddSemester(semester);
                }
                else
                {
                    string Term = textBox9.Text;

                    SemestersBL semester = new SemestersBL(Term, Year);
                    SemestersDL.AddSemesterWithoutID(semester);
                }

                dataGridView1.DataSource = SemestersDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Semester ID"))
                    return;

                int SemesterID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(SemesterID, "Semester ID"))
                    return;

                if (!ValiationFunc.CheckString(textBox9.Text, "Term"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox7.Text, "Year"))
                    return;

                int Year = int.Parse(textBox7.Text);
                if (!ValiationFunc.CheckNumber(Year, "Year"))
                    return;

                string Term = textBox9.Text;

                SemestersBL semester = new SemestersBL(SemesterID, Term, Year);
                SemestersDL.UpdateSemester(semester);
                dataGridView1.DataSource = SemestersDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Semester ID"))
                    return;

                int SemesterID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(SemesterID, "Semester ID"))
                    return;

                SemestersDL.DeleteSemester(SemesterID);
                dataGridView1.DataSource = SemestersDL.GetAll();
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