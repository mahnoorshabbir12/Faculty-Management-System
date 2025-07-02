using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1.UI
{
    public partial class FacultyCrud : Form
    {
        public FacultyCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = FacultyDL.GetAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(textBox9.Text, "Name"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Email"))
                    return;

                if (!ValiationFunc.CheckString(textBox2.Text, "Contact"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox4.Text, "Designation ID"))
                    return;

                int DesignationId = int.Parse(textBox4.Text);
                if (DesignationId < 4 || DesignationId > 7)
                {
                    MessageBox.Show("The Designation ID entered is invalid. It must be between 4 and 7.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValiationFunc.CheckString(textBox3.Text, "Research Area"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox5.Text, "Teaching Hours"))
                    return;

                int Hours = int.Parse(textBox5.Text);
                if (!ValiationFunc.CheckNumber(Hours, "Teaching Hours"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox6.Text, "User ID"))
                    return;

                int UserID = int.Parse(textBox6.Text);
                if (!ValiationFunc.CheckNumber(UserID, "User ID"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox1.Text, "Faculty ID"))
                        return;

                    int FacultyID = int.Parse(textBox1.Text);
                    if (!ValiationFunc.CheckNumber(FacultyID, "Faculty ID"))
                        return;

                    string name = textBox9.Text;
                    string email = textBox7.Text;
                    string contact = textBox2.Text;
                    string ResearchArea = textBox3.Text;

                    FacultyBL F1 = new FacultyBL(FacultyID, name, email, contact, DesignationId, ResearchArea, Hours, UserID);
                    FacultyDL.AddFaculty(F1);
                }
                else
                {
                    string name = textBox9.Text;
                    string email = textBox7.Text;
                    string contact = textBox2.Text;
                    string ResearchArea = textBox3.Text;

                    FacultyBL F1 = new FacultyBL(name, email, contact, DesignationId, ResearchArea, Hours, UserID);
                    FacultyDL.AddFacultyWithoutID(F1);
                }

                this.dataGridView1.DataSource = FacultyDL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Faculty ID"))
                    return;

                int FacultyID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(FacultyID, "Faculty ID"))
                    return;

                if (!ValiationFunc.CheckString(textBox9.Text, "Name"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Email"))
                    return;

                if (!ValiationFunc.CheckString(textBox2.Text, "Contact"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox4.Text, "Designation ID"))
                    return;

                int DesignationId = int.Parse(textBox4.Text);
                if (DesignationId < 4 || DesignationId > 7)
                {
                    MessageBox.Show("The Designation ID entered is invalid. It must be between 4 and 7.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValiationFunc.CheckString(textBox3.Text, "Research Area"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox5.Text, "Teaching Hours"))
                    return;

                int Hours = int.Parse(textBox5.Text);
                if (!ValiationFunc.CheckNumber(Hours, "Teaching Hours"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox6.Text, "User ID"))
                    return;

                int UserID = int.Parse(textBox6.Text);
                if (!ValiationFunc.CheckNumber(UserID, "User ID"))
                    return;

                string name = textBox9.Text;
                string email = textBox7.Text;
                string contact = textBox2.Text;
                string ResearchArea = textBox3.Text;

                FacultyBL F1 = new FacultyBL(FacultyID, name, email, contact, DesignationId, ResearchArea, Hours, UserID);
                FacultyDL.UpdateFaculty(F1);
                this.dataGridView1.DataSource = FacultyDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Faculty ID"))
                    return;

                int ID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ID, "Faculty ID"))
                    return;

                FacultyDL.DeleteFaculty(ID);
                this.dataGridView1.DataSource = FacultyDL.GetAll();
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