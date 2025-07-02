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
    public partial class FacultyRequestsCrud : Form
    {
        public FacultyRequestsCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = FacultyRequestsDL.GetAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = dataGridView1.SelectedRows[0]; // Get selected row
            //    txtRequestID.Text = row.Cells["RequestID"].Value.ToString();
            //    txtFacultyID.Text = row.Cells["FacultyID"].Value.ToString();
            //    txtItemID.Text = row.Cells["ItemID"].Value.ToString();
            //    txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            //    txtStatusID.Text = row.Cells["StatusID"].Value.ToString();
            //    txtRequestDate.Text = row.Cells["RequestDate"].Value.ToString();
            //}
        }
        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    int RequestID = int.Parse(textBox1.Text);
                    int FacultyID = int.Parse(textBox9.Text);
                    int ItemID = int.Parse(textBox7.Text);
                    int Quantity = int.Parse(textBox2.Text);
                    int StatusID = 8;
                    DateTime RequestDate = DateTime.Parse(textBox3.Text);
                    if (StatusID >= 8 && StatusID <= 11)
                    {
                        FacultyRequestsBL request = new FacultyRequestsBL(RequestID, FacultyID, ItemID, Quantity, StatusID, RequestDate);
                        FacultyRequestsDL.AddFacultyRequest(request);
                    }
                    else
                    {
                        string ex = "The ID entered is invalid.";
                        MessageBox.Show(ex);
                    }
                }
                else
                {
                    int FacultyID = int.Parse(textBox9.Text);
                    int ItemID = int.Parse(textBox7.Text);
                    int Quantity = int.Parse(textBox2.Text);
                    int StatusID = 8;
                    DateTime RequestDate = DateTime.Parse(textBox3.Text);

                    FacultyRequestsBL request = new FacultyRequestsBL(FacultyID, ItemID, Quantity, StatusID, RequestDate);
                    FacultyRequestsDL.AddFacultyRequestWithoutID(request);
                }
                    dataGridView1.DataSource = FacultyRequestsDL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int RequestID = int.Parse(textBox1.Text);
                int FacultyID = int.Parse(textBox9.Text);
                int ItemID = int.Parse(textBox7.Text);
                int Quantity = int.Parse(textBox2.Text);
                int StatusID = 8;
                DateTime RequestDate = DateTime.Parse(textBox3.Text);

                FacultyRequestsBL request = new FacultyRequestsBL(RequestID, FacultyID, ItemID, Quantity, StatusID, RequestDate);
                FacultyRequestsDL.UpdateFacultyRequest(request);
                dataGridView1.DataSource = FacultyRequestsDL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(textBox1.Text);
                FacultyRequestsDL.DeleteFacultyRequest(ID);
                dataGridView1.DataSource = FacultyRequestsDL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FacultyRequestsDL.GetAll();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            UI.FacultyMember.StaffDashboard newform = new UI.FacultyMember.StaffDashboard();
            this.Hide();
            newform.Show();
        }
    }
}
