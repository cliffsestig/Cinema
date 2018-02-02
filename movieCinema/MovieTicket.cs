using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema
{
    public class MovieTicket
    {
        int seatNumber { get; }
        public Movie movie { get; }
        public MovieTicket(Movie movie,int seatNumber)
        {
            this.movie = movie;
            this.seatNumber = seatNumber;
        }
    }
}
