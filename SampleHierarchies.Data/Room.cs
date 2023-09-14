using System;
using SampleHierarchies.Interfaces.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data
{
    public class Room: IRoom
    {




        public int RoomNumber { get;  set; }
        public int Capacity { get;  set; }
        public bool IsAvailable { get; set; }
        public decimal PricePerNight { get; set; }

        public Room(int roomNumber, int capacity, decimal pricePerNight)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            IsAvailable = true;
            PricePerNight = pricePerNight;
        }
    }
}
