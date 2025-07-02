using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    public class FacultyProjectsBL
    {
        public int FacultyProjectID { get; set; }
        public int FacultyID { get; set; }
        public int ProjectID { get; set; }
        public int SemesterID { get; set; }
        public int SupervisionHours { get; set; }

        public FacultyProjectsBL(int facultyProjectID, int facultyID, int projectID, int semesterID, int supervisionHours)
        {
            this.FacultyProjectID = facultyProjectID;
            this.FacultyID = facultyID;
            this.ProjectID = projectID;
            this.SemesterID = semesterID;
            this.SupervisionHours = supervisionHours;
        }
        public FacultyProjectsBL(int facultyID, int projectID, int semesterID, int supervisionHours)
        {
            this.FacultyID = facultyID;
            this.ProjectID = projectID;
            this.SemesterID = semesterID;
            this.SupervisionHours = supervisionHours;
        }
    }
}
