using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public class IMAXTicket : Ticket
    {
        bool Is3D;
        public IMAXTicket(string movieName, double price, bool Is3D) : base(movieName, TicketType.IMAX, price)
        {
            if (Is3D) { 
                price += 30;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
        }
    }
}
