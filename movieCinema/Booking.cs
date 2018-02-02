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
        public IState reservedState;
        public IState paidState;

        public IState state;

        public Booking(List<MovieTicket> ticketList)
        {
            reservedState = new ReservedState(this);
            paidState = new PaidState(this);
            this.ticketList = ticketList;
            this.totalPrice = calcPrice();
            this.state = reservedState;
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
        public IState getReservedState() {
            return this.reservedState;
        }
        public IState getPaidState()
        {
            return this.paidState;
        }
        public void setState(IState state)
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

        public void isPaid() {
            this.state.update();
        }
    }

}
