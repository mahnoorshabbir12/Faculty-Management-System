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
using WindowsFormsApp1.UI.AdminStaff;
using WindowsFormsApp1.UI.DepartmentHead;
using WindowsFormsApp1.UI.FacultyMember;

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(usernameTextBox.Text, "Username"))
                    return;

                if (!ValiationFunc.CheckString(passwordTxt.Text, "Password"))
                    return;

                List<UserBL> ListofAllUsers = UserDL.GetAll();
                string Username = usernameTextBox.Text;
                string Password = passwordTxt.Text;

                int loginResult = UserBL.Login(Username, Password, ListofAllUsers);

                switch (loginResult)
                {
                    case 1:
                        Form10 form10 = new Form10();
                        this.Hide();
                        form10.Show();
                        break;

                    case 2:
                        StaffDashboard staffDashboard = new StaffDashboard();
                        this.Hide();
                        staffDashboard.Show();
                        break;

                    case 3:
                        HeadDasboard headDasboard = new HeadDasboard();
                        this.Hide();
                        headDasboard.Show();
                        break;

                    default:
                        MessageBox.Show(
                            "Invalid username or password.",
                            "Login failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        ForgotPass forgot = new ForgotPass();
                        this.Hide();
                        forgot.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginSubmitBtn_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            //ForgotPass forgot = new ForgotPass();
            //this.Hide();
            //forgot.Show();
        }
    }
} 