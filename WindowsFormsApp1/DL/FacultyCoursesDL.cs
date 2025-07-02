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
    public class FacultyCoursesDL
    {
        static public void AddFacultyCourse(FacultyCoursesBL facultyCourse)
        {
            string dml = $"INSERT INTO faculty_courses(faculty_course_id, faculty_id, course_id, semester_id) VALUES({facultyCourse.FacultyCourseID}, {facultyCourse.FacultyID}, {facultyCourse.CourseID}, {facultyCourse.SemesterID})";
            SqlHelper.executeDML(dml);
        }
        static public void AddFacultyCourseWithoutID(FacultyCoursesBL facultyCourse)
        {
            string dml = $"INSERT INTO faculty_courses(faculty_id, course_id, semester_id) VALUES({facultyCourse.FacultyID}, {facultyCourse.CourseID}, {facultyCourse.SemesterID})";
            SqlHelper.executeDML(dml);
        }

        static public void UpdateFacultyCourse(FacultyCoursesBL facultyCourse)
        {
            string dml = $"UPDATE faculty_courses SET faculty_id = {facultyCourse.FacultyID}, course_id = {facultyCourse.CourseID}, semester_id = {facultyCourse.SemesterID} WHERE faculty_course_id = {facultyCourse.FacultyCourseID}";
            SqlHelper.executeDML(dml);
        }

        static public void DeleteFacultyCourse(int facultyCourseID)
        {
            string dml = $"DELETE FROM faculty_courses WHERE faculty_course_id = {facultyCourseID}";
            SqlHelper.executeDML(dml);
        }

        public static List<FacultyCoursesBL> GetAll()
        {
            List<FacultyCoursesBL> listOfAllFacultyCourses = new List<FacultyCoursesBL>();
            string query = "SELECT * FROM faculty_courses";
            DataTable dtFacultyCourses = SqlHelper.getDataTable(query);
            foreach (DataRow dr in dtFacultyCourses.Rows)
            {
                string facultyCourseID = dr["faculty_course_id"].ToString();
                string facultyID = dr["faculty_id"].ToString();
                string courseID = dr["course_id"].ToString();
                string semesterID = dr["semester_id"].ToString();

                FacultyCoursesBL facultyCourse = new FacultyCoursesBL(int.Parse(facultyCourseID), int.Parse(facultyID), int.Parse(courseID), int.Parse(semesterID));
                listOfAllFacultyCourses.Add(facultyCourse);
            }
            return listOfAllFacultyCourses;
        }
    }
}
