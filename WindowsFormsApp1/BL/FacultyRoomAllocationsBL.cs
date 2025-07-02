using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    public class FacultyRoomAllocationsBL
    {
        public int AllocationID { get; set; }
        public int FacultyID { get; set; }
        public int RoomID { get; set; }
        public int ReservedHours { get; set; }
        public int SemesterID { get; set; }

        public FacultyRoomAllocationsBL(int allocationID, int facultyID, int roomID, int reservedHours, int semesterID)
        {
            this.AllocationID = allocationID;
            this.FacultyID = facultyID;
            this.RoomID = roomID;
            this.ReservedHours = reservedHours;
            this.SemesterID = semesterID;
        }
        public FacultyRoomAllocationsBL(int facultyID, int roomID, int reservedHours, int semesterID)
        {
            this.FacultyID = facultyID;
            this.RoomID = roomID;
            this.ReservedHours = reservedHours;
            this.SemesterID = semesterID;
        }
    }
}
