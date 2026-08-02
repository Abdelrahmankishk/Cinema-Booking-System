using System;
using System.Collections.Generic;
using System.Dynamic;
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
    public abstract class Ticket
    {
        public int ID;
        public Ticket(string movieName, TicketType type, double price)
        {
            MovieName = movieName;
            Type = type;
            Price = price;
            ticketCounter++;
            ID = ticketCounter;
        }
        public Ticket(string MovieName) : this(MovieName, TicketType.Standard, 50)
        {
        }
        static int ticketCounter = 0;
        static double TaxPercent = 0.14;
        private string movieName;
        private double price;

        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    movieName = value;
                }
            }
        }
        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }
        public double Price { get { return price; } set { if (value > 0) price = value; } }

        public double PriceAfterTax => Price + (Price * TaxPercent);
        public void ApplyDiscount(double discountAmount)
        {
            if (discountAmount < Price)
            {
                Price = PriceAfterTax - discountAmount;
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
                Console.WriteLine($"Total (14% tax)   : {PriceAfterTax:N2}");
        }

        public int GetTotalTickets()
        {
            return ticketCounter;
        }

        public override string ToString()
        {
            return $"Ticket #{ID}| Type: {Type} | {movieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP";
        }
    }
}
