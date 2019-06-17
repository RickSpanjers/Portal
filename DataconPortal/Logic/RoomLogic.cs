using DataconPortal.Classes;
using DataconPortal.Context;
using DataconPortal.Data;
using DataconPortal.Repositories;
using DataconPortal.TestContext;
using System;
using System.Collections.Generic;

namespace DataconPortal.Logic
{
    class RoomLogic
    {
        RoomRepository RoomRepo = new RoomRepository(new RoomContext());

        public void DeleteRoom(string SelectedRoom)
        {
            var AllRooms = RoomRepo.LoadRooms();
            foreach (var SingleRoom in AllRooms)
            {
                if (SingleRoom.RetrieveRoomName() == SelectedRoom)
                {
                    RoomRepo.DeleteRoom(SelectedRoom);
                }
            }
        }

        public List<Room> RetrieveAllRooms()
        {
            return RoomRepo.LoadRooms();
        }

        public void AddRoom(Room r)
        {
            RoomRepo.AddRoom(r);
        }

        public void UpdateRoom(Room r)
        {
            RoomRepo.UpdateRoom(r);
        }
    }
}
