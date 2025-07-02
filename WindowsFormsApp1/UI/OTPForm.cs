using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1.UI
{
    public partial class OTPForm : Form
    {
        public OTPForm()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(To.Text, "OTP"))
                    return;

                if (!ValiationFunc.CheckInteger(To.Text, "OTP"))
                    return;

                int enteredOTP = int.Parse(To.Text);

                if (enteredOTP == ForgotPass.StoreOTP)
                {
                    ResetPass resetPass = new ResetPass();
                    this.Hide();
                    resetPass.Show();
                }
                else
                {
                    MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}