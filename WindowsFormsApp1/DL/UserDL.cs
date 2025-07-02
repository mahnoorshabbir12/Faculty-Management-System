using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using WindowsFormsApp1.Backend;
using WindowsFormsApp1.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.DL
{
    public class UserDL
    {
        public static List<UserBL> ListofAllUsers = new List<UserBL>();
        //static public void AddUser(UserBL user)
        //{
        //    string HashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);
        //    string dml = "insert into users values('{0}','{1}','{2}','{3}','{4}')";
        //    dml = String.Format(dml, user.Username, user.Email, HashedPassword, user.RoleID);
        //    SqlHelper.executeDML(dml);
        //}
        static public void AddUser(UserBL user)
        {
            string HashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);
            string dml = $"INSERT INTO users (user_id, username, email, password_hash, role_id) VALUES({user.UserID},'{user.Username}','{user.Email}','{HashedPassword}','{user.RoleID}')";
            SqlHelper.executeDML(dml);
        }
        static public void AddUserWithoutID(UserBL user)
        {
            string HashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);
            string dml = $"INSERT INTO users (username, email, password_hash, role_id) VALUES('{user.Username}','{user.Email}','{HashedPassword}','{user.RoleID}')";
            SqlHelper.executeDML(dml);
        }
        static public void UpdatePassword(string Email, string Password)
        {
            string HashedPassword = BCrypt.Net.BCrypt.HashPassword(Password);
            string dml = $"Update users SET Password_hash = '{HashedPassword}' where email = '{Email}'";
            SqlHelper.executeDML(dml);
        }
        static public void UpdateUser(UserBL user)
        {
            string HashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);
            string dml = $"Update users SET Password_hash = '{HashedPassword}', username = '{user.Username}', email = '{user.Email}', role_id = '{user.RoleID}' where user_id = '{user.UserID}'";
            SqlHelper.executeDML(dml);
        }
        static public void DeleteUser(int UserID)
        {
            string dml = $"DELETE FROM users WHERE user_id = {UserID}";
            SqlHelper.executeDML(dml);
        }
        public static List<UserBL> GetAll()
        {
            List<UserBL> ListofAllUsers = new List<UserBL>();
            string query = "select * from users";
            DataTable dtUsers = SqlHelper.getDataTable(query);
            foreach (DataRow dr in dtUsers.Rows)
            {
                string UserID = dr["user_id"].ToString();
                string Username = dr["username"].ToString();
                string Email = dr["email"].ToString();
                string Password = dr["password_hash"].ToString();
                string RoleID = dr["role_id"].ToString();
                UserBL user = new UserBL(int.Parse(UserID), Username, Email, Password, int.Parse(RoleID));
                ListofAllUsers.Add(user);
            }
            return ListofAllUsers;
        }

    }
}
