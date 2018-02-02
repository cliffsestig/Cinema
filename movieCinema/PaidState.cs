using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema
{
    class PaidState : IState
    {
        Booking booking;
        public PaidState(Booking booking)
        {
            this.booking = booking;
        }
        public void update()
        {
            Console.WriteLine("State is already paid nothing to update.");
        }
    }
}
