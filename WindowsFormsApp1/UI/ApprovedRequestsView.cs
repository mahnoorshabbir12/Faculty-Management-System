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
    public partial class ApprovedRequestsView: Form
    {
        private string request_id = "-1";
        public ApprovedRequestsView()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = FacultyRequestsDL.GetApproved(); 
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int requestID = int.Parse(textBox1.Text);
                int statusID = int.Parse(textBox2.Text);
                FacultyRequestsBL F1 = new FacultyRequestsBL(requestID, statusID);
                FacultyRequestsDL.UpdateFacultyRequestStatus(F1);
                dataGridView1.DataSource = FacultyRequestsDL.GetApproved();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                textBox2.Text = row.Cells["status_id"].Value.ToString();
                request_id = row.Cells["request_id"].Value.ToString();
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
