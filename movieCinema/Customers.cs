using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema
{
    class Customers
    {
      public string name;
        public List<Booking> booking;
        public Customers(List<Booking> booking,string name)
        {
            this.booking = booking;
            this.name = name;
        }
    }
}
