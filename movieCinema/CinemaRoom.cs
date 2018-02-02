using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema
{
    public class CinemaRoom
    {
        public CinemaRoom(int room, int capacity)
        {
            roomNumber = room;
            roomCapacity = capacity;
        }
        int roomNumber { get; set; }
        int roomCapacity { get; set; }

    }
}
