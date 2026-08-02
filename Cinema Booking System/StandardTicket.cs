using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public class StandardTicket : Ticket
    {
        SeatLocation seatLocation;
        public StandardTicket(string movieName, double price, SeatLocation seat) : base(movieName, TicketType.Standard, price)
        {
            Seat = seat;
        }

        public override string PrintTicket()
        {
            return base.PrintTicket() + $" | Seat: {Seat.Row}-{Seat.Number}"; ;
        }
    }
}
