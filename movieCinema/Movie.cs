using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema
{
    public class Movie
    {
        public CinemaRoom cinemaRoom;
       public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public Movie(string name,string description,decimal price,CinemaRoom cinemaRoom)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.cinemaRoom = cinemaRoom;
        }
    }
}
