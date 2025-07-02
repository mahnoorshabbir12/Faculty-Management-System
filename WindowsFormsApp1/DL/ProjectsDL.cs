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
    public class ProjectsDL
    {
        static public void AddProject(ProjectsBL project)
        {
            string dml = $"INSERT INTO projects(project_id, title, description) VALUES({project.ProjectID}, '{project.Title}', '{project.Description}')";
            SqlHelper.executeDML(dml);
        }
        static public void AddProjectWithoutID(ProjectsBL project)
        {
            string dml = $"INSERT INTO projects(title, description) VALUES('{project.Title}', '{project.Description}')";
            SqlHelper.executeDML(dml);
        }

        static public void UpdateProject(ProjectsBL project)
        {
            string dml = $"UPDATE projects SET title = '{project.Title}', description = '{project.Description}' WHERE project_id = {project.ProjectID}";
            SqlHelper.executeDML(dml);
        }

        static public void DeleteProject(int projectID)
        {
            string dml = $"DELETE FROM projects WHERE project_id = {projectID}";
            SqlHelper.executeDML(dml);
        }

        public static List<ProjectsBL> GetAll()
        {
            List<ProjectsBL> listOfAllProjects = new List<ProjectsBL>();
            string query = "SELECT * FROM projects";
            DataTable dtProjects = SqlHelper.getDataTable(query);

            foreach (DataRow dr in dtProjects.Rows)
            {
                string projectID = dr["project_id"].ToString();
                string title = dr["title"].ToString();
                string description = dr["description"].ToString();

                ProjectsBL project = new ProjectsBL(int.Parse(projectID), title, description);
                listOfAllProjects.Add(project);
            }
            return listOfAllProjects;
        }
    }
}
