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
    public partial class FacultyRoomAllocationsCrud : Form
    {
        public FacultyRoomAllocationsCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = FacultyRoomAllocationsDL.GetAll();
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

                if (!ValiationFunc.CheckInteger(textBox7.Text, "Room ID"))
                    return;

                int RoomID = int.Parse(textBox7.Text);
                if (!ValiationFunc.CheckNumber(RoomID, "Room ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Reserved Hours"))
                    return;

                int ReservedHours = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(ReservedHours, "Reserved Hours"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox4.Text, "Semester ID"))
                    return;

                int SemesterID = int.Parse(textBox4.Text);
                if (!ValiationFunc.CheckNumber(SemesterID, "Semester ID"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox1.Text, "Allocation ID"))
                        return;

                    int AllocationID = int.Parse(textBox1.Text);
                    if (!ValiationFunc.CheckNumber(AllocationID, "Allocation ID"))
                        return;

                    FacultyRoomAllocationsBL allocation = new FacultyRoomAllocationsBL(AllocationID, FacultyID, RoomID, ReservedHours, SemesterID);
                    FacultyRoomAllocationsDL.AddFacultyRoomAllocation(allocation);
                }
                else
                {
                    FacultyRoomAllocationsBL allocation = new FacultyRoomAllocationsBL(FacultyID, RoomID, ReservedHours, SemesterID);
                    FacultyRoomAllocationsDL.AddFacultyRoomAllocationWithoutID(allocation);
                }

                dataGridView1.DataSource = FacultyRoomAllocationsDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Allocation ID"))
                    return;

                int AllocationID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(AllocationID, "Allocation ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox9.Text, "Faculty ID"))
                    return;

                int FacultyID = int.Parse(textBox9.Text);
                if (!ValiationFunc.CheckNumber(FacultyID, "Faculty ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox7.Text, "Room ID"))
                    return;

                int RoomID = int.Parse(textBox7.Text);
                if (!ValiationFunc.CheckNumber(RoomID, "Room ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Reserved Hours"))
                    return;

                int ReservedHours = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(ReservedHours, "Reserved Hours"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox4.Text, "Semester ID"))
                    return;

                int SemesterID = int.Parse(textBox4.Text);
                if (!ValiationFunc.CheckNumber(SemesterID, "Semester ID"))
                    return;

                FacultyRoomAllocationsBL allocation = new FacultyRoomAllocationsBL(AllocationID, FacultyID, RoomID, ReservedHours, SemesterID);
                FacultyRoomAllocationsDL.UpdateFacultyRoomAllocation(allocation);
                dataGridView1.DataSource = FacultyRoomAllocationsDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Allocation ID"))
                    return;

                int ID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ID, "Allocation ID"))
                    return;

                FacultyRoomAllocationsDL.DeleteFacultyRoomAllocation(ID);
                dataGridView1.DataSource = FacultyRoomAllocationsDL.GetAll();
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