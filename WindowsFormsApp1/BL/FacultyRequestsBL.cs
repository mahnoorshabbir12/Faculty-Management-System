using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    public class FacultyRequestsBL
    {
        public int RequestID { get; set; }
        public int FacultyID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public int StatusID { get; set; }
        public DateTime RequestDate { get; set; }

        public FacultyRequestsBL(int requestID, int facultyID, int itemID, int quantity, int statusID, DateTime requestDate)
        {
            this.RequestID = requestID;
            this.FacultyID = facultyID;
            this.ItemID = itemID;
            this.Quantity = quantity;
            this.StatusID = statusID;
            this.RequestDate = requestDate;
        }
        public FacultyRequestsBL(int requestID, int facultyID, int itemID, int quantity, int statusID)
        {
            this.RequestID = requestID;
            this.FacultyID = facultyID;
            this.ItemID = itemID;
            this.Quantity = quantity;
            this.StatusID = statusID;
        }
        public FacultyRequestsBL(int facultyID, int itemID, int quantity, int statusID)
        {
            this.FacultyID = facultyID;
            this.ItemID = itemID;
            this.Quantity = quantity;
            this.StatusID = statusID;
        }
        public FacultyRequestsBL(int facultyID, int itemID, int quantity, int statusID, DateTime requestDate)
        {
            this.FacultyID = facultyID;
            this.ItemID = itemID;
            this.Quantity = quantity;
            this.StatusID = statusID;
            this.RequestDate = requestDate;
        }
        public FacultyRequestsBL(int requestID, int statusID)
        {
            this.RequestID = requestID;
            this.StatusID = statusID;
        }
    }
}
