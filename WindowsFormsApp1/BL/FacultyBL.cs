using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FacultyBL
    {
        public int FacultyID { get; set; }
        public string FacultyName { get; set; }
        public string FacultyEmail { get; set; }
        public string FacultyContact { get; set; }
        public int DesignationID { get; set; }
        public string ResearchArea { get; set; }
        public int Hours { get; set; }
        public int UserID { get; set; }
        public FacultyBL(int FacultyID, string facultyName, string facultyEmail, string facultyContact, int designationID, string researchArea, int hours, int userID)
        {
            this.FacultyID = FacultyID;
            this.FacultyName = facultyName;
            this.FacultyEmail = facultyEmail;
            this.FacultyContact = facultyContact;
            this.DesignationID = designationID;
            this.ResearchArea = researchArea;
            this.Hours = hours;
            this.UserID = userID;
        }
        public FacultyBL(string facultyName, string facultyEmail, string facultyContact, int designationID, string researchArea, int hours, int userID)
        {
            this.FacultyName = facultyName;
            this.FacultyEmail = facultyEmail;
            this.FacultyContact = facultyContact;
            this.DesignationID = designationID;
            this.ResearchArea = researchArea;
            this.Hours = hours;
            this.UserID = userID;

        }
    }
}
