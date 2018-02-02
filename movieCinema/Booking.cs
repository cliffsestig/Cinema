using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieCinema
{

    public class Booking
    {
        List<MovieTicket> ticketList;
        decimal totalPrice;
        public IState state;

        public Booking(List<MovieTicket> ticketList)
        {
            this.state = new CreatedState();
            this.ticketList = ticketList;
            this.totalPrice = calcPrice();
        }
        private decimal calcPrice()
        {
            decimal tPrice = 0;
            foreach (var ticket in ticketList)
            {
                tPrice += ticket.movie.price;
            }
            return tPrice;
        }

        // This method should be called when a movie is 24 hours before the screen time with the parameter time as false. 
        // This method should be called when a movie is 12 hours before the screen time with the parameter time as true. 
        public void checkIfPaid(Boolean time)
        {
            if (!this.state.Equals(new PaidState()) && !time)
            {
                Console.WriteLine("Moet een bericht gestuurd worden");
            } else if (!this.state.Equals(new PaidState()) && time)
            {
                this.onCancelled();
            }
        }

        private void setState(IState state)
        {
            this.state = state;
        }

        public IState getState() {
            return this.state;
        }
        public decimal getTotalPrice()
        {
            return this.totalPrice;
        }

        public void onReserved() {
            setState(this.state.reserved());
        }

        public void onCancelled() {
            setState(this.state.cancelled());
        }
        public void onPaid() {
            setState(this.state.paid());
        }

        public void onCreated() {
            setState(this.state.created());
        }
    }

}
