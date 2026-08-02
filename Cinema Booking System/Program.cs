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

            string movieName = default!;
            int ticketType = default;
            SeatLocation seatLocation = new();
            double ticketPrice = default;
            double Discount = default;

            cinema.OpenCinema();

            #region Ticket Booking
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========== Ticket Booking ==========");
            Console.ResetColor();
            for (int i = 0; i < NumberofTickets; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Enter data for Ticket {i + 1}: ");
                Console.ResetColor();

                Ticket ticket1 = ConsoleHelper.TicketInput(movieName!, ticketType, seatLocation, ticketPrice, Discount);
                cinema.AddTicket(ticket1);
            }
            #endregion

            cinema.AllTickets();
            Ticket.GetTotalTickets();
            
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========== Generating Booking References ==========");
            Console.ResetColor();
            Console.WriteLine($"Booking Reference 1: {BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"Booking Reference 2: {BookingHelper.GenerateBookingReference()}");
            #endregion

            cinema.CloseCinema();
        }
    }
}
