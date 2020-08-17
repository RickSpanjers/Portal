using DataconPortal.Classes;
using DataconPortal.Interfaces;
using DataconPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Repositories
{
    class RoomRepository
    {
        private IRoom RoomInterface;

        public RoomRepository(IRoom Context)
        {
            RoomInterface = Context;
        }

        public void AddRoom(Room r)
        {
            RoomInterface.AddRoom(r);
        }

        public List<Room> LoadRooms()
        {
            return RoomInterface.LoadRooms();
        }

        public void DeleteRoom(string Name)
        {
            RoomInterface.DeleteRoom(Name);
        }

        public void UpdateRoom(Room r)
        {
            RoomInterface.UpdateRoom(r);
        }
    }
}
