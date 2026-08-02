using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public class VIPTicket : Ticket
    {
        bool hasLoungeAccess;
        decimal ServiceFee = 50.00m;
        public VIPTicket(string movieName, double price, bool hasLoungeAccess, decimal ServiceFee = 50.00m) : base(movieName, TicketType.VIP, price)
        {
            this.hasLoungeAccess = hasLoungeAccess;
            this.ServiceFee = ServiceFee;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Lounge Access: {hasLoungeAccess} | Service Fee: {ServiceFee} EGP";
        }
    }
}
