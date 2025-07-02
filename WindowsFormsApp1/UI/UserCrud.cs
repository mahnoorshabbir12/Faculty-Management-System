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
    public partial class UserCrud : Form
    {
        public UserCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = UserDL.GetAll();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(textBox1.Text, "Username"))
                    return;

                if (!ValiationFunc.CheckString(textBox9.Text, "Email"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Password"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Role ID"))
                    return;

                int RoleID = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(RoleID, "Role ID"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox3.Text, "User ID"))
                        return;

                    int UserID = int.Parse(textBox3.Text);
                    if (!ValiationFunc.CheckNumber(UserID, "User ID"))
                        return;

                    string Username = textBox1.Text;
                    string Email = textBox9.Text;
                    string Password = textBox7.Text;

                    UserBL user = new UserBL(UserID, Username, Email, Password, RoleID);
                    UserDL.AddUser(user);
                }
                else
                {
                    string Username = textBox1.Text;
                    string Email = textBox9.Text;
                    string Password = textBox7.Text;

                    UserBL user = new UserBL(Username, Email, Password, RoleID);
                    UserDL.AddUserWithoutID(user);
                }

                dataGridView1.DataSource = UserDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox3.Text, "User ID"))
                    return;

                int UserID = int.Parse(textBox3.Text);
                if (!ValiationFunc.CheckNumber(UserID, "User ID"))
                    return;

                if (!ValiationFunc.CheckString(textBox1.Text, "Username"))
                    return;

                if (!ValiationFunc.CheckString(textBox9.Text, "Email"))
                    return;

                if (!ValiationFunc.CheckString(textBox7.Text, "Password"))
                    return;

                if (!ValiationFunc.CheckInteger(textBox2.Text, "Role ID"))
                    return;

                int RoleID = int.Parse(textBox2.Text);
                if (!ValiationFunc.CheckNumber(RoleID, "Role ID"))
                    return;

                string Username = textBox1.Text;
                string Email = textBox9.Text;
                string Password = textBox7.Text;

                UserBL user = new UserBL(UserID, Username, Email, Password, RoleID);
                UserDL.UpdateUser(user);
                dataGridView1.DataSource = UserDL.GetAll();
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
                if (!ValiationFunc.CheckInteger(textBox3.Text, "User ID"))
                    return;

                int UserID = int.Parse(textBox3.Text);
                if (!ValiationFunc.CheckNumber(UserID, "User ID"))
                    return;

                UserDL.DeleteUser(UserID);
                dataGridView1.DataSource = UserDL.GetAll();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}