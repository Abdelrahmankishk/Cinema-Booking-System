using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public class VIPTicket : Ticket, IUnifiedPrinting, ICloneable
    {
        public bool IsBooked { get; set; }
        bool hasLoungeAccess;
        decimal ServiceFee = 50.00m;
        public VIPTicket(string movieName, double price, bool hasLoungeAccess, decimal ServiceFee = 50.00m , bool isBooked = false) : base(movieName, TicketType.VIP, price)
        {
            this.hasLoungeAccess = hasLoungeAccess;
            this.ServiceFee = ServiceFee;
            IsBooked = isBooked;
        }

        public override string PrintTicket()
        {
            return base.PrintTicket() + $" | Lounge Access: {(hasLoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
        }
        
        public void PrintItself()
        {
            Console.WriteLine(PrintTicket());
        }

        public object Clone()
        {
            return new VIPTicket(this.MovieName, this.Price, this.hasLoungeAccess, this.ServiceFee, this.IsBooked);
        }
    }
}
