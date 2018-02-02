using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema
{
    class ReservedState : IState
    {
        Booking booking;
        public ReservedState(Booking booking)
        {
            this.booking = booking;
        }
        public void update()
        {
            booking.setState(booking.getPaidState());
        }
    }
}
