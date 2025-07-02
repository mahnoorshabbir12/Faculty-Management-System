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
    public partial class AdminCourseScheduleCrud : Form
    {
        public AdminCourseScheduleCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = AdminCourseScheduleDL.GetAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(textBox7.Text, "Day of Week"))
                    return;

                if (!ValiationFunc.CheckTime(textBox2.Text, "Start Time"))
                    return;

                if (!ValiationFunc.CheckTime(textBox4.Text, "End Time"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox1.Text, "Schedule ID"))
                        return;

                    int ScheduleID = int.Parse(textBox1.Text);
                    if (!ValiationFunc.CheckNumber(ScheduleID, "Schedule ID"))
                        return;

                    if (!ValiationFunc.CheckInteger(textBox9.Text, "Faculty Course ID"))
                        return;

                    int FacultyCourseID = int.Parse(textBox9.Text);
                    if (!ValiationFunc.CheckNumber(FacultyCourseID, "Faculty Course ID"))
                        return;

                    if (!ValiationFunc.CheckInteger(textBox3.Text, "Room ID"))
                        return;

                    int RoomID = int.Parse(textBox3.Text);
                    if (!ValiationFunc.CheckNumber(RoomID, "Room ID"))
                        return;

                    string DayOfWeek = textBox7.Text;
                    TimeSpan StartTime = TimeSpan.Parse(textBox2.Text);
                    TimeSpan EndTime = TimeSpan.Parse(textBox4.Text);

                    AdminCourseScheduleBL schedule = new AdminCourseScheduleBL(ScheduleID, FacultyCourseID, RoomID, DayOfWeek, StartTime, EndTime);
                    AdminCourseScheduleDL.AddAdminCourseSchedule(schedule);
                }
                else
                {
                    if (!ValiationFunc.CheckInteger(textBox9.Text, "Faculty Course ID"))
                        return;

                    int FacultyCourseID = int.Parse(textBox9.Text);
                    if (!ValiationFunc.CheckNumber(FacultyCourseID, "Faculty Course ID"))
                        return;

                    if (!ValiationFunc.CheckInteger(textBox3.Text, "Room ID"))
                        return;

                    int RoomID = int.Parse(textBox3.Text);
                    if (!ValiationFunc.CheckNumber(RoomID, "Room ID"))
                        return;

                    string DayOfWeek = textBox7.Text;
                    TimeSpan StartTime = TimeSpan.Parse(textBox2.Text);
                    TimeSpan EndTime = TimeSpan.Parse(textBox4.Text);

                    AdminCourseScheduleBL schedule = new AdminCourseScheduleBL(FacultyCourseID, RoomID, DayOfWeek, StartTime, EndTime);
                    AdminCourseScheduleDL.AddAdminCourseScheduleWithoutID(schedule);
                }

                dataGridView1.DataSource = AdminCourseScheduleDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Schedule ID"))
                    return;

                int ScheduleID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ScheduleID, "Schedule ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox9.Text, "Faculty Course ID"))
                    return;

                int FacultyCourseID = int.Parse(textBox9.Text);
                if (!ValiationFunc.CheckNumber(FacultyCourseID, "Faculty Course ID"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox3.Text, "Room ID"))
                    return;

                int RoomID = int.Parse(textBox3.Text);
                if (!ValiationFunc.CheckNumber(RoomID, "Room ID"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Day of Week"))
                    return;

                if (!ValiationFunc.CheckTime(textBox2.Text, "Start Time"))
                    return;

                if (!ValiationFunc.CheckTime(textBox4.Text, "End Time"))
                    return;

                string DayOfWeek = textBox7.Text;
                TimeSpan StartTime = TimeSpan.Parse(textBox2.Text);
                TimeSpan EndTime = TimeSpan.Parse(textBox4.Text);

                AdminCourseScheduleBL schedule = new AdminCourseScheduleBL(ScheduleID, FacultyCourseID, RoomID, DayOfWeek, StartTime, EndTime);
                AdminCourseScheduleDL.UpdateAdminCourseSchedule(schedule);
                dataGridView1.DataSource = AdminCourseScheduleDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Schedule ID"))
                    return;

                int ID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ID, "Schedule ID"))
                    return;

                AdminCourseScheduleDL.DeleteAdminCourseSchedule(ID);
                dataGridView1.DataSource = AdminCourseScheduleDL.GetAll();
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