using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public class Cinema
    {
        Ticket[] _Tickets = new Ticket[20];

        public Ticket this[int index]
        {
            get
            {
                if (index < 0 || index >= _Tickets.Length)
                {
                    return null!;
                }
                return _Tickets[index];
            }
            set
            {
                if (index < 0 || index >= _Tickets.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                _Tickets[index] = value;
            }
        }
        public Ticket this[string movieName]
        {
            get {
                foreach (var ticket in _Tickets) { 
                 if (ticket != null && ticket.MovieName.ToLower() == movieName.ToLower())
                    {
                        return ticket;
                    }
                }
                return null!;
            }
        }

        public bool AddTicket(Ticket t)
        {
            for (int  i = 0;  i < _Tickets.Length;  i++)
            {
                if( _Tickets[i] == null)
                {
                    _Tickets[i] = t;
                    return true;
                }
            }
            return false;
        }

        public void AllTickets()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========== All Tickets ==========");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var ticket in _Tickets)
            {
                if (ticket != null)
                {
                    Console.WriteLine($"Ticket #{ticket.ID} | {ticket.MovieName} | {ticket.Type} | Seat: {ticket.Seat.Row}-{ticket.Seat.Number} | Price: {ticket.Price} EGP | After Tax: {ticket.PriceAfterTax} EGP");
                }
            }
        }
    }
}
