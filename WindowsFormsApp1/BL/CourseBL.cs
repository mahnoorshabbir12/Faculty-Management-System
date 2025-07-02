using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    public class CourseBL
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseType { get; set; }
        public int CreditHours { get; set; }
        public int ContactHours { get; set; }
        public CourseBL(int courseID, string courseName, string courseType, int creditHours, int contactHours)
        {
            this.CourseID = courseID;
            this.CourseName = courseName;
            this.CourseType = courseType;
            this.CreditHours = creditHours;
            this.ContactHours = contactHours;
        }
        public CourseBL(string courseName, string courseType, int creditHours, int contactHours)
        {
            this.CourseName = courseName;
            this.CourseType = courseType;
            this.CreditHours = creditHours;
            this.ContactHours = contactHours;
        }
    }
}
