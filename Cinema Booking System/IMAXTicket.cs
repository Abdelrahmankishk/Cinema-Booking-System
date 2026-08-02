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
        public IMAXTicket(string movieName, double price, bool Is3D) : base(movieName, TicketType.IMAX, (Is3D ? price + 30.00 : price))
        {
            this.Is3D = Is3D;
            
        }
        
        public override string ToString()
        {
            return base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
        }
    }
}
