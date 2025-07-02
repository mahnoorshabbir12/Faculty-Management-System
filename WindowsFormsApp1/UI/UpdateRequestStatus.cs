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
    public partial class UpdateRequestStatus : Form
    {
        private string request_id = "-1";
        public UpdateRequestStatus()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = FacultyRequestsDL.GetApprovedByHead();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Request ID"))
                    return;

                int requestID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(requestID, "Request ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox4.Text, "Status ID"))
                    return;

                int statusID = int.Parse(textBox4.Text);
                if (!ValiationFunc.CheckNumber(statusID, "Status ID"))
                    return;

                FacultyRequestsBL F1 = new FacultyRequestsBL(requestID, statusID);
                FacultyRequestsDL.UpdateFacultyRequestStatus(F1);
                dataGridView1.DataSource = FacultyRequestsDL.GetApprovedByHead();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                textBox4.Text = row.Cells["status_id"].Value.ToString();
                request_id = row.Cells["request_id"].Value.ToString();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            UI.DepartmentHead.HeadDasboard newform = new UI.DepartmentHead.HeadDasboard();
            this.Hide();
            newform.Show();
        }
    }
}