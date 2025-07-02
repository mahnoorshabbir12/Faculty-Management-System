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
    public class RoomsDL
    {
        static public void AddRoom(RoomsBL room)
        {
            string dml = $"INSERT INTO rooms(room_id, room_name, room_type, capacity) VALUES({room.RoomID}, '{room.RoomName}', '{room.RoomType}', {room.Capacity})";
            SqlHelper.executeDML(dml);
        }
        static public void AddRoomWithoutID(RoomsBL room)
        {
            string dml = $"INSERT INTO rooms(room_name, room_type, capacity) VALUES('{room.RoomName}', '{room.RoomType}', {room.Capacity})";
            SqlHelper.executeDML(dml);
        }

        static public void UpdateRoom(RoomsBL room)
        {
            string dml = $"UPDATE rooms SET room_name = '{room.RoomName}', room_type = '{room.RoomType}', capacity = {room.Capacity} WHERE room_id = {room.RoomID}";
            SqlHelper.executeDML(dml);
        }

        static public void DeleteRoom(int roomID)
        {
            string dml = $"DELETE FROM rooms WHERE room_id = {roomID}";
            SqlHelper.executeDML(dml);
        }

        public static List<RoomsBL> GetAll()
        {
            List<RoomsBL> listOfAllRooms = new List<RoomsBL>();
            string query = "SELECT * FROM rooms";
            DataTable dtRooms = SqlHelper.getDataTable(query);

            foreach (DataRow dr in dtRooms.Rows)
            {
                string roomID = dr["room_id"].ToString();
                string roomName = dr["room_name"].ToString();
                string roomType = dr["room_type"].ToString();
                string capacity = dr["capacity"].ToString();

                RoomsBL room = new RoomsBL(int.Parse(roomID), roomName, roomType, int.Parse(capacity));
                listOfAllRooms.Add(room);
            }
            return listOfAllRooms;
        }
    }
}
