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
    public partial class ProjectsCrud : Form
    {
        public ProjectsCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ProjectsDL.GetAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(textBox9.Text, "Title"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Description"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox1.Text, "Project ID"))
                        return;

                    int ProjectID = int.Parse(textBox1.Text);
                    if (!ValiationFunc.CheckNumber(ProjectID, "Project ID"))
                        return;

                    string Title = textBox9.Text;
                    string Description = textBox7.Text;

                    ProjectsBL project = new ProjectsBL(ProjectID, Title, Description);
                    ProjectsDL.AddProject(project);
                }
                else
                {
                    string Title = textBox9.Text;
                    string Description = textBox7.Text;

                    ProjectsBL project = new ProjectsBL(Title, Description);
                    ProjectsDL.AddProjectWithoutID(project);
                }

                dataGridView1.DataSource = ProjectsDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Project ID"))
                    return;

                int ProjectID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ProjectID, "Project ID"))
                    return;

                if (!ValiationFunc.CheckString(textBox9.Text, "Title"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Description"))
                    return;

                string Title = textBox9.Text;
                string Description = textBox7.Text;

                ProjectsBL project = new ProjectsBL(ProjectID, Title, Description);
                ProjectsDL.UpdateProject(project);
                dataGridView1.DataSource = ProjectsDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Project ID"))
                    return;

                int ID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ID, "Project ID"))
                    return;

                ProjectsDL.DeleteProject(ID);
                dataGridView1.DataSource = ProjectsDL.GetAll();
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