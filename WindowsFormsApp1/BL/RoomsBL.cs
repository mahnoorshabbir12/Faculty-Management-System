using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    public class RoomsBL
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public int Capacity { get; set; }

        public RoomsBL(int roomID, string roomName, string roomType, int capacity)
        {
            this.RoomID = roomID;
            this.RoomName = roomName;
            this.RoomType = roomType;
            this.Capacity = capacity;
        }
        public RoomsBL(string roomName, string roomType, int capacity)
        {
            this.RoomName = roomName;
            this.RoomType = roomType;
            this.Capacity = capacity;
        }
    }
}
