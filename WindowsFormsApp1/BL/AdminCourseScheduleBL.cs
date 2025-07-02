using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    public class AdminCourseScheduleBL
    {
        public int ScheduleID { get; set; }
        public int FacultyCourseID { get; set; }
        public int RoomID { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public AdminCourseScheduleBL(int ScheduleID, int facultyCourseID, int roomID, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            this.ScheduleID = ScheduleID;
            this.FacultyCourseID = facultyCourseID;
            this.RoomID = roomID;
            this.DayOfWeek = dayOfWeek;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
        public AdminCourseScheduleBL(int facultyCourseID, int roomID, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            this.FacultyCourseID = facultyCourseID;
            this.RoomID = roomID;
            this.DayOfWeek = dayOfWeek;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
    }
}
