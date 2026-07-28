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
        public int Number;
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
        public Ticket(string MovieName) : this(MovieName, TicketType.Standard, new SeatLocation { Row = 'A', Number = 1 }, 50)
        {
        }
        static double TaxPercent = 0.14;
        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }
        double Price { get; set; }

        double CalcTotal()
        {
            double PriceWithTax = Price + (Price * TaxPercent);
            return PriceWithTax;
        }
        public void ApplyDiscount(double discountAmount)
        {
            if (discountAmount < Price)
            {
                Price = CalcTotal() - discountAmount;
                Console.WriteLine("===== After Discount =====");
                Console.WriteLine($"Discount Before     : {discountAmount:N2}");
                discountAmount = 0;
                Console.WriteLine($"Discount After      : {discountAmount:N2}");
                Console.WriteLine($"Price After Discount: {Price:N2}");
                Console.WriteLine($"Movie : {MovieName}");
                Console.WriteLine($"Type  : {Type}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Discount Amount!");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("NO DISCOUNT APPLIED!");
                Console.ResetColor();
            }

        }

        public void PrintTicket()
        {
                Console.WriteLine("===== Ticket Info =====");
                Console.WriteLine($"Movie   : {MovieName}");
                Console.WriteLine($"Type    : {Type}");
                Console.WriteLine($"Seat    : {Seat.Row}{Seat.Number}");
                Console.WriteLine($"Price   : {Price:N2}");
                Console.WriteLine($"Total (14% tax)   : {CalcTotal():N2}");
        }

    }
}
