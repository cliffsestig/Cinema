using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            CinemaRoom cin = new CinemaRoom(1, 100);
            Movie mov = new Movie("Alladin", "Een disney film", 10, cin);
            MovieTicket ticket = new MovieTicket(mov, 15);
            MovieTicket ticket1 = new MovieTicket(mov, 16);
            MovieTicket ticket2 = new MovieTicket(mov, 22);
            MovieTicket ticket3 = new MovieTicket(mov, 23);
            MovieTicket ticket4 = new MovieTicket(mov, 24);

            List<MovieTicket> l = new List<MovieTicket>() { ticket, ticket1, ticket2, ticket3, ticket4 };
            Booking book = new Booking(l);

            Console.WriteLine((book.getState().ToString() == "movieCinema.ReservedState"));
            book.isPaid();
            Console.WriteLine(book.getState());
        }
    }
}
