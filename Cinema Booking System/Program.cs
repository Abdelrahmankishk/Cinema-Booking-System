using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace Cinema_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberofTickets = 3;
            Cinema cinema = new Cinema();
            IUnifiedPrinting[] tickets = new IUnifiedPrinting[NumberofTickets];

            string movieName = default!;
            int ticketType = default;
            SeatLocation seatLocation = new();
            double ticketPrice = default;
            double Discount = default;

            cinema.OpenCinema();

            #region Ticket Input
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========== Ticket Booking ==========");
            Console.ResetColor();
            for (int i = 0; i < NumberofTickets; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Enter data for Ticket {i + 1}: ");
                Console.ResetColor();

                IUnifiedPrinting ticket1 = ConsoleHelper.TicketInput(movieName!, ticketType, seatLocation, ticketPrice, Discount);
                tickets[i] = ticket1;
                cinema.AddTicket(ticket1);
            }
            #endregion

            #region Overloading Test (SetPrice Method)
            //Ticket test = new VIPTicket("Avengers", 200, true);
            //Console.WriteLine("========== SetPrice Test ==========");
            //test.setPrice(150);
            //test.setPrice(150, 1.5f);

            #endregion
            cinema.AllTickets();
            Ticket.GetTotalTickets();

            #region Clone A Ticket
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--- Clone Test ---");
            Console.ResetColor();
            

            StandardTicket ClonedTicket = (StandardTicket)tickets[0].Clone();
          
            #region test if the cloned ticket is a deep copy
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            ClonedTicket.IsBooked = true;
            ClonedTicket.Seat = new SeatLocation { Row = 'Z', Number = 99 };
            ClonedTicket.MovieName = "Interstellar";
            Console.Write("Cloned: ");
            ClonedTicket.PrintItself();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Original: ");
            tickets[0].PrintItself();
            Console.ResetColor();
            Console.WriteLine();
            #endregion
            #endregion

            #region Book a Ticket
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("========== After Booking ==========");
            Console.ResetColor();   
            cinema.BookTicket(tickets[0]);
            #endregion

            #region Cancel a Ticket
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("========== After Canceling ==========");
            Console.ResetColor();
            cinema.CancelTicket(tickets[0]);
            Console.WriteLine();
            #endregion

            #region Search by Movie
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("========== Search by Movie ==========");
            //Console.ResetColor();

            //Ticket searchedTicket = cinema["Avengers"];
            //if (searchedTicket != null)
            //{
            //    Console.ForegroundColor = ConsoleColor.Cyan;
            //    Console.WriteLine($"Found: Ticket #{searchedTicket.ID} | {searchedTicket.MovieName} | {searchedTicket.Type} | Seat: {searchedTicket.Seat.Row}-{searchedTicket.Seat.Number} | Price: {searchedTicket.Price} EGP | After Tax: {searchedTicket.PriceAfterTax} EGP");
            //    Console.ResetColor();
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkRed;
            //    Console.WriteLine("NOT FOUND!");
            //    Console.ResetColor();
            //}
            #endregion

            #region Generating and print 2 booking references
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("========== Generating Booking References ==========");
            //Console.ResetColor();
            //Console.WriteLine($"Booking Reference 1: {BookingHelper.GenerateBookingReference()}");
            //Console.WriteLine($"Booking Reference 2: {BookingHelper.GenerateBookingReference()}");
            #endregion
            BookingHelper.PrintPrintableTickets(tickets.ToList());

            cinema.CloseCinema();
        }
    }
}
