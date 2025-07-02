using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Backend;
using WindowsFormsApp1.BL;

namespace WindowsFormsApp1.DL
{
    public class CourseDL
    {
        static public void AddCourse(CourseBL course)
        {
            string dml = $"INSERT INTO courses(course_id,course_name, course_type, credit_hours, contact_hours) VALUES({course.CourseID},'{course.CourseName}','{course.CourseType}',{course.CreditHours},{course.ContactHours})";
            SqlHelper.executeDML(dml);
        }
        static public void AddCourseWithoutID(CourseBL course)
        {
            string dml = $"INSERT INTO courses(course_name, course_type, credit_hours, contact_hours) VALUES('{course.CourseName}','{course.CourseType}',{course.CreditHours},{course.ContactHours})";
            SqlHelper.executeDML(dml);
        }
        static public void UpdateCourse(CourseBL c)
        {
            string dml = $"Update courses SET course_name = '{c.CourseName}',Course_Type = '{c.CourseType}',credit_Hours = {c.CreditHours},contact_Hours = {c.ContactHours} where course_id = {c.CourseID}";
            SqlHelper.executeDML(dml);
        }
        static public void DeleteCourse(int CourseID)
        {
            string dml = $"Delete from courses where course_id = {CourseID}";
            SqlHelper.executeDML(dml);
        }
        public static List<CourseBL> GetAll()
        {
            List<CourseBL> ListofAllCourses = new List<CourseBL>();
            string query = "select * from Courses";
            DataTable dtFaculty = SqlHelper.getDataTable(query);
            foreach (DataRow dr in dtFaculty.Rows)
            {
                string CourseID = dr["course_id"].ToString();
                string CourseName = dr["Course_Name"].ToString();
                string CourseType = dr["Course_Type"].ToString();
                string CreditHours = dr["Credit_Hours"].ToString();
                string ContactHours = dr["Contact_Hours"].ToString();

                CourseBL course = new CourseBL(int.Parse(CourseID), CourseName, CourseType, int.Parse(CreditHours), int.Parse(ContactHours));
                ListofAllCourses.Add(course);
            }
            return ListofAllCourses;
        }
    }
}
