using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WindowsFormsApp1.Backend;
using WindowsFormsApp1.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using WindowsFormsApp1.DL;
using System.Security.Policy;

namespace WindowsFormsApp1
{
    public class FacultyDL
    {
        static public void AddFaculty(FacultyBL faculty)
        {
            string dml = $"INSERT INTO faculty(faculty_id, name, email, contact,designation_id,research_area,total_teaching_hours,user_id) VALUES({faculty.FacultyID},'{faculty.FacultyName}','{faculty.FacultyEmail}',{faculty.FacultyContact},{faculty.DesignationID},'{faculty.ResearchArea}',{faculty.Hours},{faculty.UserID})";
            SqlHelper.executeDML(dml);
        }
        static public void AddFacultyWithoutID(FacultyBL faculty)
        {
            string dml = $"INSERT INTO faculty(name, email, contact,designation_id,research_area,total_teaching_hours,user_id) VALUES('{faculty.FacultyName}','{faculty.FacultyEmail}','{faculty.FacultyContact}'," +
                $"{faculty.DesignationID},'{faculty.ResearchArea}',{faculty.Hours},{faculty.UserID})";
            SqlHelper.executeDML(dml);
        }
        static public void UpdateFaculty(FacultyBL f)
        {
            string dml = $"Update faculty SET name = '{f.FacultyName}',email = '{f.FacultyEmail}',contact = '{f.FacultyContact}',designation_id = {f.DesignationID}, research_area = '{f.ResearchArea}',total_teaching_hours = {f.Hours},user_id = {f.UserID} where faculty_id = {f.FacultyID}";
            SqlHelper.executeDML(dml);
        }
        static public void DeleteFaculty(int FacultyID)
        {
            string dml = $"Delete from faculty where faculty_id = {FacultyID}";
            SqlHelper.executeDML(dml);
        }
        public static List<FacultyBL> GetAll()
        {
            List<FacultyBL> ListofAllFaculty = new List<FacultyBL>();
            string query = "select * from Faculty";
            DataTable dtFaculty = SqlHelper.getDataTable(query);
            foreach (DataRow dr in dtFaculty.Rows)
            {
                string FacultyID = dr["faculty_id"].ToString();
                string Name = dr["name"].ToString();
                string Email = dr["email"].ToString();
                string Contact = dr["contact"].ToString();
                string DesignationID = dr["designation_id"].ToString();
                string ResearchArea = dr["research_area"].ToString();
                string Hours = dr["total_teaching_hours"].ToString();
                string UserID = dr["user_id"].ToString();
                FacultyBL faculty = new FacultyBL(int.Parse(FacultyID),Name,Email,Contact,int.Parse(DesignationID), ResearchArea,int.Parse(Hours),int.Parse(UserID));
                ListofAllFaculty.Add(faculty);
            }
            return ListofAllFaculty;
        }
    }
}
