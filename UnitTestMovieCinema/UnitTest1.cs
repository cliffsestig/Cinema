using Microsoft.VisualStudio.TestTools.UnitTesting;
using movieCinema;
using System;
using System.Collections.Generic;

namespace UnitTestMovieCinema
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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

            Assert.AreEqual("movieCinema.ReservedState", book.getState().ToString());
            book.isPaid();

        }

        [TestMethod]
        public void TestMethod2()
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
            book.isPaid();
            Assert.AreEqual("movieCinema.PaidState", book.getState().ToString());


        }
        [TestMethod]
        public void TestTotalPrice()
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
            book.isPaid();
            Assert.AreEqual(50, book.getTotalPrice());


        }
    }
}
