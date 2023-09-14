using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data
{
    public interface IRoom
    {
        int RoomNumber { get; set; }
        int Capacity { get; set; }
        bool IsAvailable { get; set; }
        decimal PricePerNight { get; set; }
    }

}
