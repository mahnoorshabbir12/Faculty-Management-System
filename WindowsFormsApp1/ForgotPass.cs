using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1
{
    public partial class ForgotPass : Form
    {
        public static int OTP = 0;
        public static int StoreOTP = 0;
        public static string StoreEmail = "";

        public ForgotPass()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(guna2TextBox1.Text, "Email"))
                    return;

                string userEmail = guna2TextBox1.Text;
                List<UserBL> UserList = UserDL.GetAll();

                if (UserBL.EmailCheck(userEmail, UserList))
                {
                    Random random = new Random();
                    int OTP = random.Next(100000, 999999);
                    StoreOTP = OTP;

                    string appEmail = "tulipkardo123@gmail.com";
                    string username = "tulipkardo123@gmail.com";
                    string password = "rfkkrdxwqyyzmfta";

                    StoreEmail = userEmail;
                    string subject = "Reset Password Verification Code";
                    string body = "" + OTP;

                    MailMessage mail = new MailMessage(appEmail, userEmail, subject, body);
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.Credentials = new NetworkCredential(username, password);
                    client.EnableSsl = true;
                    client.Send(mail);

                    UI.OTPForm otp = new UI.OTPForm();
                    this.Hide();
                    otp.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Email doesn't exist...",
                        "Invalid Email",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}