using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DL;
using BCrypt.Net;
using static Guna.UI2.Native.WinApi;
using System.Web.UI;
using System.Windows.Forms;

namespace WindowsFormsApp1.BL
{
    public class UserBL
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public UserBL()
        {
        }
        public UserBL(int UserID, string Username, string Email, string Password, int RoleID)
        {
            this.UserID = UserID;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
            this.RoleID = RoleID;
        }
        public UserBL(string Username, string Email, string Password, int RoleID)
        {
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
            this.RoleID = RoleID;
        }
        public UserBL(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
        public static bool EmailCheck(string Email, List<UserBL> ListofAllUsers)
        {
            foreach (var user in ListofAllUsers)
            {
                if (user.Email == Email)
                {
                        return true; 
                }
            }
            return false; 
        }
        public static int Login(string Username, string Password, List<UserBL> ListofAllUsers)
        {
            
            try
            {
                foreach (var user in ListofAllUsers)
                {
                    //MessageBox.Show(user.Username + " " + user.Password, "Success", MessageBoxButtons.OK);
                    bool Check = BCrypt.Net.BCrypt.Verify(Password, user.Password);
                    
                    if (user.Username == Username && Check)
                    {
                        //MessageBox.Show("Result:" + Check, "Success", MessageBoxButtons.OK);
                        if (user.RoleID == 1)
                        {
                            return 1;
                        }
                        if (user.RoleID == 2)
                        {
                            return 2;
                        }
                        if (user.RoleID == 3)
                        {
                            return 3;
                        }
                    }
                }
                return 0; // Login failed
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
        }

        public static string GetHashedPassword(string password)
        {
            string pass = "";
            pass = BCrypt.Net.BCrypt.HashPassword(password);
            return pass;
        }

    }
}
