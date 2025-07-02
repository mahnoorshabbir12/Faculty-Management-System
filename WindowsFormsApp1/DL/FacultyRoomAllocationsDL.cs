using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Backend;
using WindowsFormsApp1.BL;

namespace WindowsFormsApp1.DL
{
    public class FacultyRoomAllocationsDL
    {
        static public void AddFacultyRoomAllocation(FacultyRoomAllocationsBL facultyRoomAllocation)
        {
            string dml = $"INSERT INTO faculty_room_allocations(allocation_id, faculty_id, room_id, reserved_hours, semester_id) VALUES({facultyRoomAllocation.AllocationID}, {facultyRoomAllocation.FacultyID}, {facultyRoomAllocation.RoomID}, {facultyRoomAllocation.ReservedHours}, {facultyRoomAllocation.SemesterID})";
            SqlHelper.executeDML(dml);
        }
        static public void AddFacultyRoomAllocationWithoutID(FacultyRoomAllocationsBL facultyRoomAllocation)
        {
            string dml = $"INSERT INTO faculty_room_allocations(faculty_id, room_id, reserved_hours, semester_id) VALUES({facultyRoomAllocation.FacultyID}, {facultyRoomAllocation.RoomID}, {facultyRoomAllocation.ReservedHours}, {facultyRoomAllocation.SemesterID})";
            SqlHelper.executeDML(dml);
        }

        static public void UpdateFacultyRoomAllocation(FacultyRoomAllocationsBL facultyRoomAllocation)
        {
            string dml = $"UPDATE faculty_room_allocations SET faculty_id = {facultyRoomAllocation.FacultyID}, room_id = {facultyRoomAllocation.RoomID}, reserved_hours = {facultyRoomAllocation.ReservedHours}, semester_id = {facultyRoomAllocation.SemesterID} WHERE allocation_id = {facultyRoomAllocation.AllocationID}";
            SqlHelper.executeDML(dml);
        }

        static public void DeleteFacultyRoomAllocation(int allocationID)
        {
            string dml = $"DELETE FROM faculty_room_allocations WHERE allocation_id = {allocationID}";
            SqlHelper.executeDML(dml);
        }

        public static List<FacultyRoomAllocationsBL> GetAll()
        {
            List<FacultyRoomAllocationsBL> listOfAllFacultyRoomAllocations = new List<FacultyRoomAllocationsBL>();
            string query = "SELECT * FROM faculty_room_allocations";
            DataTable dtFacultyRoomAllocations = SqlHelper.getDataTable(query);

            foreach (DataRow dr in dtFacultyRoomAllocations.Rows)
            {
                string allocationID = dr["allocation_id"].ToString();
                string facultyID = dr["faculty_id"].ToString();
                string roomID = dr["room_id"].ToString();
                string reservedHours = dr["reserved_hours"].ToString();
                string semesterID = dr["semester_id"].ToString();

                FacultyRoomAllocationsBL facultyRoomAllocation = new FacultyRoomAllocationsBL(
                    int.Parse(allocationID), int.Parse(facultyID), int.Parse(roomID), int.Parse(reservedHours), int.Parse(semesterID));

                listOfAllFacultyRoomAllocations.Add(facultyRoomAllocation);
            }
            return listOfAllFacultyRoomAllocations;
        }
    }
}
