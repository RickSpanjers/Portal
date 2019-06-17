using DataconPortal.Classes;
using DataconPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Interfaces
{
    interface IRoom
    {
        void AddRoom(Room r);
        List<Room> LoadRooms();
        void DeleteRoom(string Name);
        void UpdateRoom(Room r);
    }
}
