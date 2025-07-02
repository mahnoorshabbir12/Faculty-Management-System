using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    public class FacultyCoursesBL
    {
        public int FacultyCourseID { get; set; }
        public int FacultyID { get; set; }
        public int CourseID { get; set; }
        public int SemesterID { get; set; }

        public FacultyCoursesBL(int facultyCourseID, int facultyID, int courseID, int semesterID)
        {
            this.FacultyCourseID = facultyCourseID;
            this.FacultyID = facultyID;
            this.CourseID = courseID;
            this.SemesterID = semesterID;
        }
        public FacultyCoursesBL(int facultyID, int courseID, int semesterID)
        {
            this.FacultyID = facultyID;
            this.CourseID = courseID;
            this.SemesterID = semesterID;
        }
    }
}
