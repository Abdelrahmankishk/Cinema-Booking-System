using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public class Projector
    {
        public void StartProjector()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Projector started.");
            Console.ResetColor();
        }

        public void StopProjector()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Projector stopped.");
            Console.ResetColor();
        }

    }
    public class Cinema
    {
        Projector Projector = new();
        public string? CinemaName { get; }
        Ticket[] _Tickets = new Ticket[20];
        IUnifiedPrinting[] _Tickets2 = new IUnifiedPrinting[20];


        #region Ticket (abstract) Class Indexer

        //public Ticket this[int index]
        //{
        //    get
        //    {
        //        if (index < 0 || index >= _Tickets.Length)
        //        {
        //            return null!;
        //        }
        //        return _Tickets[index];
        //    }
        //    set
        //    {
        //        if (index < 0 || index >= _Tickets.Length)
        //        {
        //            throw new IndexOutOfRangeException("Index is out of range.");
        //        }
        //        _Tickets[index] = value;
        //    }
        //}
        #endregion
        public IUnifiedPrinting this[int index]
        {
            get
            {
                if (index < 0 || index >= _Tickets.Length)
                {
                    return null!;
                }
                return _Tickets2[index];
            }
            set
            {
                if (index < 0 || index >= _Tickets.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                _Tickets2[index] = value;
            }
        }
        public Ticket this[string movieName]
        {
            get
            {
                foreach (var ticket in _Tickets)
                {
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
            for (int i = 0; i < _Tickets.Length; i++)
            {
                if (_Tickets[i] == null)
                {
                    _Tickets[i] = t;
                    return true;
                }
            }
            return false;
        }
        public bool AddTicket(IUnifiedPrinting t)
        {
            for (int i = 0; i < _Tickets2.Length; i++)
            {
                if (_Tickets2[i] == null)
                {
                    _Tickets2[i] = t;
                    return true;
                }
            }
            return false;
        }

        public void AllTickets()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========== All Tickets ==========");
            Console.ResetColor();
            foreach (var ticket in _Tickets2)
            {
                if (ticket != null)
                {
                    ticket.PrintItself();
                }
            }
            Console.WriteLine();
        }
        public static void ProcessTicket(Ticket ticket)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========== Process Single Ticket ==========");
            Console.WriteLine(ticket.PrintTicket());
            Console.ResetColor();
        }
        public void OpenCinema()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========== Cinema Opened ==========");
            Console.ResetColor();
            Projector.StartProjector();
        }
        public void CloseCinema()
        {
            Projector.StopProjector();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("========== Cinema Closed ==========");
            Console.ResetColor();

        }

        public void BookTicket(IUnifiedPrinting ticket)
        {
            if (ticket != null)
            {
                if (!ticket.IsBooked)
                {
                    ticket.IsBooked = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ticket booked successfully.");
                    Console.ResetColor();
                    ticket.PrintItself();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ticket is already booked.");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a Valid Ticket!");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        public void CancelTicket(IUnifiedPrinting ticket)
        {
            if (ticket != null)
            {
                if (ticket.IsBooked)
                {
                    ticket.IsBooked = false;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ticket cancelled successfully.");
                    Console.ResetColor();
                    ticket.PrintItself();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ticket is not booked yet.");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a Valid Ticket!");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
