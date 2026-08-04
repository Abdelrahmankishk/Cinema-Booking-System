using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public class IMAXTicket : Ticket, IUnifiedPrinting, ICloneable
    {
        public bool IsBooked { get; set; }
        bool Is3D;
        public IMAXTicket(string movieName, double price, bool Is3D, bool isBooked = false) : base(movieName, TicketType.IMAX, (Is3D ? price + 30.00 : price))
        {
            this.Is3D = Is3D;
            IsBooked = isBooked;
        }

        public override string PrintTicket()
        {
            return base.PrintTicket() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
        }
        
        public void PrintItself()
        {
            Console.WriteLine(PrintTicket() + $" | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public object Clone()
        {
            return new IMAXTicket(this.MovieName, this.Price, this.Is3D, this.IsBooked);
        }
    }
}
