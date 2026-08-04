using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public class StandardTicket : Ticket, IUnifiedPrinting, ICloneable
    {
        SeatLocation seatLocation;

        public bool IsBooked { get; set; }

        public StandardTicket(string movieName, double price, SeatLocation seat, bool isBooked = false) : base(movieName, TicketType.Standard, price)
        {
            Seat = seat;
            IsBooked = isBooked;
        }

        public override string PrintTicket()
        {
            return base.PrintTicket() + $" | Seat: {Seat.Row}-{Seat.Number}"; ;
        }
        public void PrintItself()
        {
            Console.WriteLine(PrintTicket() + $" | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public object Clone()
        {
            return new StandardTicket(this.MovieName, this.Price, Seat.DeepCopy(), this.IsBooked);
        }
    }
}
