using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    public class SemestersBL
    {
        public int SemesterID { get; set; }
        public string Term { get; set; }
        public int Year { get; set; }

        public SemestersBL(int semesterID, string term, int year)
        {
            this.SemesterID = semesterID;
            this.Term = term;
            this.Year = year;
        }
        public SemestersBL(string term, int year)
        {
            this.Term = term;
            this.Year = year;
        }
    }
}
