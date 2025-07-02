using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Web.UI.WebControls;

namespace WindowsFormsApp1.Backend
{
    public class SqlHelper
    {
        public static string constring = "Server = localhost;Uid=root;Pwd= Nalaiq123@;Database= midprojectdb";
        public static void executeDML(string dml)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(dml, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable getDataTable(string sql)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public static int ReturnInteger(string query)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            return (Int32)cmd.ExecuteScalar();
        }
        public static int GetID(string CoulumnName, string TableName)
        {
            string query = "Select Max(" + CoulumnName + ") from" + TableName;
            int ID = SqlHelper.ReturnInteger(query);
            return ID;
        }

    }
}
