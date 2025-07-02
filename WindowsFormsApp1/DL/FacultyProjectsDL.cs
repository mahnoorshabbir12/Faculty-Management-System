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
    public class FacultyProjectsDL
    {
        static public void AddFacultyProject(FacultyProjectsBL facultyProject)
        {
            string dml = $"INSERT INTO faculty_projects(faculty_project_id, faculty_id, project_id, semester_id, supervision_hours) VALUES({facultyProject.FacultyProjectID}, {facultyProject.FacultyID}, {facultyProject.ProjectID}, {facultyProject.SemesterID}, {facultyProject.SupervisionHours})";
            SqlHelper.executeDML(dml);
        }
        static public void AddFacultyProjectWithoutID(FacultyProjectsBL facultyProject)
        {
            string dml = $"INSERT INTO faculty_projects(faculty_id, project_id, semester_id, supervision_hours) VALUES({facultyProject.FacultyID}, {facultyProject.ProjectID}, {facultyProject.SemesterID}, {facultyProject.SupervisionHours})";
            SqlHelper.executeDML(dml);
        }

        static public void UpdateFacultyProject(FacultyProjectsBL facultyProject)
        {
            string dml = $"UPDATE faculty_projects SET faculty_id = {facultyProject.FacultyID}, project_id = {facultyProject.ProjectID}, semester_id = {facultyProject.SemesterID}, supervision_hours = {facultyProject.SupervisionHours} WHERE faculty_project_id = {facultyProject.FacultyProjectID}";
            SqlHelper.executeDML(dml);
        }

        static public void DeleteFacultyProject(int facultyProjectID)
        {
            string dml = $"DELETE FROM faculty_projects WHERE faculty_project_id = {facultyProjectID}";
            SqlHelper.executeDML(dml);
        }

        public static List<FacultyProjectsBL> GetAll()
        {
            List<FacultyProjectsBL> listOfAllFacultyProjects = new List<FacultyProjectsBL>();
            string query = "SELECT * FROM faculty_projects";
            DataTable dtFacultyProjects = SqlHelper.getDataTable(query);
            foreach (DataRow dr in dtFacultyProjects.Rows)
            {
                string facultyProjectID = dr["faculty_project_id"].ToString();
                string facultyID = dr["faculty_id"].ToString();
                string projectID = dr["project_id"].ToString();
                string semesterID = dr["semester_id"].ToString();
                string supervisionHours = dr["supervision_hours"].ToString();

                FacultyProjectsBL facultyProject = new FacultyProjectsBL(int.Parse(facultyProjectID), int.Parse(facultyID), int.Parse(projectID), int.Parse(semesterID), int.Parse(supervisionHours));
                listOfAllFacultyProjects.Add(facultyProject);
            }
            return listOfAllFacultyProjects;
        }
    }

}
