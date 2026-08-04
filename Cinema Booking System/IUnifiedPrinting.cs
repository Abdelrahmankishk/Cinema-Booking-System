using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public interface IUnifiedPrinting
    {
        bool IsBooked { get; }
        void PrintItself();
    }
}
