using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Data
{
    class Room
    {
        private int roomID;
        private string roomName;
        private string roomDescription;

        public Room()
        {

        }

        public Room(string roomName)
        {
            this.roomName = roomName;
        }

        public Room(int roomID, string roomName)
        {
            this.roomID = roomID;
            this.roomName = roomName;
        }

        public int RetrieveRoomID()
        {
            return roomID;
        }

        public string RetrieveRoomName()
        {
            return roomName;
        }

        public string SetRoomName
        {
            set{ roomName = value; }
        }

        public string RoomName
        {
            get
            {
                return roomName;
            }

            set
            {
                roomName = value;
            }
        }



    }
}
