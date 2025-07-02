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
    public partial class RoomsCrud : Form
    {
        public RoomsCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = RoomsDL.GetAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(textBox9.Text, "Room Name"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Room Type"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Capacity"))
                    return;

                int Capacity = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(Capacity, "Capacity"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox1.Text, "Room ID"))
                        return;

                    int RoomID = int.Parse(textBox1.Text);
                    if (!ValiationFunc.CheckNumber(RoomID, "Room ID"))
                        return;

                    string RoomName = textBox9.Text;
                    string RoomType = textBox7.Text;

                    RoomsBL room = new RoomsBL(RoomID, RoomName, RoomType, Capacity);
                    RoomsDL.AddRoom(room);
                }
                else
                {
                    string RoomName = textBox9.Text;
                    string RoomType = textBox7.Text;

                    RoomsBL room = new RoomsBL(RoomName, RoomType, Capacity);
                    RoomsDL.AddRoomWithoutID(room);
                }

                dataGridView1.DataSource = RoomsDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Room ID"))
                    return;

                int RoomID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(RoomID, "Room ID"))
                    return;

                if (!ValiationFunc.CheckString(textBox9.Text, "Room Name"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Room Type"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Capacity"))
                    return;

                int Capacity = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(Capacity, "Capacity"))
                    return;

                string RoomName = textBox9.Text;
                string RoomType = textBox7.Text;

                RoomsBL room = new RoomsBL(RoomID, RoomName, RoomType, Capacity);
                RoomsDL.UpdateRoom(room);
                dataGridView1.DataSource = RoomsDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Room ID"))
                    return;

                int ID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ID, "Room ID"))
                    return;

                RoomsDL.DeleteRoom(ID);
                dataGridView1.DataSource = RoomsDL.GetAll();
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