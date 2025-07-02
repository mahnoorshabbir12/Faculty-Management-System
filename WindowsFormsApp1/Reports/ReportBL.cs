using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ReportBL
    {
        public string ItemName { get; set; }
        public int ConsumableID { get; set; }
        public int FacultyID { get; set; }
        public string FacultyName { get; set; }
        public int DesignationID { get; set; }
        public int RequestID { get; set; }
        public int Quantity { get; set; }
        public int StatusID { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
