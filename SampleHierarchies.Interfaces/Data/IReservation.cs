using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data
{
    public interface IReservation
    {
        string GuestName { get;  set; }
        DateTime CheckInDate { get;  set; }
        DateTime CheckOutDate { get;  set; }
    }
}
