using SampleHierarchies.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data
{
    internal class Reservation: IReservation
    {
        public string GuestName { get; set; }
        public Room Room { get;  set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Reservation(string guestName, Room room, DateTime checkInDate, DateTime checkOutDate)
        {
            GuestName = guestName;
            Room = room;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

    }
}
