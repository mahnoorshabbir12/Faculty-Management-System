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
    public class FacultyAdminRoleDL
    {
        static public void AddFacultyAdminRole(FacultyAdminRoleBL facultyAdminRole)
        {
            string dml = $"INSERT INTO faculty_admin_roles(admin_role_id, faculty_id, role_name, semester_id) VALUES({facultyAdminRole.AdminRoleID}, {facultyAdminRole.FacultyID}, '{facultyAdminRole.RoleName}', {facultyAdminRole.SemesterID})";
            SqlHelper.executeDML(dml);
        }
        static public void AddFacultyAdminRoleWithoutID(FacultyAdminRoleBL facultyAdminRole)
        {
            string dml = $"INSERT INTO faculty_admin_roles(faculty_id, role_name, semester_id) VALUES({facultyAdminRole.FacultyID}, '{facultyAdminRole.RoleName}', {facultyAdminRole.SemesterID})";
            SqlHelper.executeDML(dml);
        }

        static public void UpdateFacultyAdminRole(FacultyAdminRoleBL facultyAdminRole)
        {
            string dml = $"UPDATE faculty_admin_roles SET role_name = '{facultyAdminRole.RoleName}', semester_id = {facultyAdminRole.SemesterID} WHERE admin_role_id = {facultyAdminRole.AdminRoleID} AND faculty_id = {facultyAdminRole.FacultyID}";
            SqlHelper.executeDML(dml);
        }

        static public void DeleteFacultyAdminRole(int AdminRoleID)
        {
            string dml = $"DELETE FROM faculty_admin_roles WHERE admin_role_id = {AdminRoleID}";
            SqlHelper.executeDML(dml);
        }

        public static List<FacultyAdminRoleBL> GetAll()
        {
            List<FacultyAdminRoleBL> listofAllFacultyAdminRoles = new List<FacultyAdminRoleBL>();
            string query = "SELECT * FROM faculty_admin_roles";
            DataTable dtFacultyAdminRole = SqlHelper.getDataTable(query);

            foreach (DataRow dr in dtFacultyAdminRole.Rows)
            {
                int adminRoleID = int.Parse(dr["admin_role_id"].ToString());
                int facultyID = int.Parse(dr["faculty_id"].ToString());
                string roleName = dr["role_name"].ToString();
                int semesterID = int.Parse(dr["semester_id"].ToString());

                FacultyAdminRoleBL facultyAdminRole = new FacultyAdminRoleBL(adminRoleID, facultyID, roleName, semesterID);
                listofAllFacultyAdminRoles.Add(facultyAdminRole);
            }
            return listofAllFacultyAdminRoles;
        }
    }
}
