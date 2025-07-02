using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Backend;
using WindowsFormsApp1.BL;

namespace WindowsFormsApp1.DL
{
    public class AdminCourseScheduleDL
    {
        static public void AddAdminCourseSchedule(AdminCourseScheduleBL schedule)
        {
            string dml = $"INSERT INTO faculty_course_schedule(schedule_id, faculty_course_id, room_id, day_of_week, start_time, end_time) VALUES({schedule.ScheduleID},{schedule.FacultyCourseID}, {schedule.RoomID}, '{schedule.DayOfWeek}', '{schedule.StartTime}', '{schedule.EndTime}')";
            SqlHelper.executeDML(dml);
        }
        static public void AddAdminCourseScheduleWithoutID(AdminCourseScheduleBL schedule)
        {
            string dml = $"INSERT INTO faculty_course_schedule(faculty_course_id, room_id, day_of_week, start_time, end_time) VALUES({schedule.FacultyCourseID}, {schedule.RoomID}, '{schedule.DayOfWeek}', '{schedule.StartTime}', '{schedule.EndTime}')";
            SqlHelper.executeDML(dml);
        }

        static public void UpdateAdminCourseSchedule(AdminCourseScheduleBL schedule)
        {
            string dml = $"UPDATE faculty_course_schedule SET faculty_course_id = {schedule.FacultyCourseID}, room_id = {schedule.RoomID}, day_of_week = '{schedule.DayOfWeek}', start_time = '{schedule.StartTime}', end_time = '{schedule.EndTime}' WHERE schedule_id = {schedule.ScheduleID}";
            MessageBox.Show(dml, "Success", MessageBoxButtons.OK);
            SqlHelper.executeDML(dml);
        }

        static public void DeleteAdminCourseSchedule(int scheduleID)
        {
            string dml = $"DELETE FROM faculty_course_schedule WHERE schedule_id = {scheduleID}";
            SqlHelper.executeDML(dml);
        }

        public static List<AdminCourseScheduleBL> GetAll()
        {
            List<AdminCourseScheduleBL> listOfAllSchedules = new List<AdminCourseScheduleBL>();
            string query = "SELECT * FROM faculty_course_schedule";
            DataTable dtSchedule = SqlHelper.getDataTable(query);
            foreach (DataRow dr in dtSchedule.Rows)
            {
                string ScheduleID = dr["schedule_id"].ToString();
                string facultyCourseID = dr["faculty_course_id"].ToString();
                string roomID = dr["room_id"].ToString();
                string dayOfWeek = dr["day_of_week"].ToString();
                string startTime = dr["start_time"].ToString();
                string endTime = dr["end_time"].ToString();

                AdminCourseScheduleBL schedule = new AdminCourseScheduleBL(int.Parse(ScheduleID),int.Parse(facultyCourseID), int.Parse(roomID), dayOfWeek, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                listOfAllSchedules.Add(schedule);
            }
            return listOfAllSchedules;
        }

        public static DataTable GetDataTable()
        {
            string sql = "SELECT fs.schedule_id AS ScheduleID, fs.faculty_course_id AS FacultyCourseID, r.room_id AS RoomID, fs.day_of_week AS DayofWeek, fs.start_time AS StartTime, fs.end_time AS EndTime, r.room_name AS RoomName, r.room_type AS RoomType, r.capacity AS Capactiy FROM faculty_course_schedule fs JOIN rooms r ON r.room_id = fs.room_id";
            DataTable dt = SqlHelper.getDataTable(sql);
            return dt;
        }
    }
}
