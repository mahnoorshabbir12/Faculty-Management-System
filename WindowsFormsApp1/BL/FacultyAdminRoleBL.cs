using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    public class FacultyAdminRoleBL
    {
        public int AdminRoleID { get; set; }
        public int FacultyID { get; set; }
        public string RoleName { get; set; }
        public int SemesterID { get; set; }

        public FacultyAdminRoleBL(int adminRoleID, int facultyID, string roleName, int semesterID)
        {
            this.AdminRoleID = adminRoleID;
            this.FacultyID = facultyID;
            this.RoleName = roleName;
            this.SemesterID = semesterID;
        }
        public FacultyAdminRoleBL(int facultyID, string roleName, int semesterID)
        {
            this.FacultyID = facultyID;
            this.RoleName = roleName;
            this.SemesterID = semesterID;
        }
    }
}
