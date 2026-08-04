using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public static class BookingHelper
    {
        static int Counter = 0;
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            if(numberOfTickets >= 5)
            {
                return (numberOfTickets * pricePerTicket) * 0.9;
            }
            else
            {
                return numberOfTickets * pricePerTicket;
            }
        }

        public static string GenerateBookingReference()
        {
            Counter++;
            return $"BK-{Counter}";
        }

        public static void PrintPrintableTickets(List<IUnifiedPrinting> tickets)
        {
            foreach (var ticket in tickets)
            {
                ticket.PrintItself();
            }
        }
    }
}
