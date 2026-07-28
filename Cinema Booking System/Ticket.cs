using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public enum TicketType
    {
        Standard,
        VIP,
        IMAX
    }
    public struct SeatLocation {
        public char Row;
        public int Column;
    }
    public class Ticket
    {
        public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }
        public Ticket(string MovieName) :this(MovieName, TicketType.Standard, new SeatLocation { Row = 'A', Column = 1 }, 50)
        {
        }
        static double TaxPercent = 0.14;
        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }
        double Price { get; set; }

        public double CalcTotal()
        {
            double PriceWithTax = Price + (Price * TaxPercent);
            return PriceWithTax;
        }
    }
}
