using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System
{
    public class ConsoleHelper
    {
        public static IUnifiedPrinting TicketInput(string movieName, int ticketType, SeatLocation seatLocation, double ticketPrice,double Discount)
        {
            IUnifiedPrinting ticket = default!;
            bool exit = false;
            do
            {
                try
                {
                    Console.Write("Enter Movie Name: ");
                    movieName = Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(movieName))
                    {
                        throw new ArgumentException("Movie name cannot be empty");
                    }
                    Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
                    ticketType = int.Parse(Console.ReadLine()!);
                    if (ticketType < 0 || ticketType > 2)
                    {
                        throw new Exception("Ticket type must be 0, 1, or 2.");
                    }
                    Console.Write("Enter Seat Row (A, B, C...): ");
                    seatLocation.Row = char.Parse(Console.ReadLine()!.ToUpper());
                    if (seatLocation.Row < 'A' || seatLocation.Row > 'Z')
                    {
                        throw new Exception("Seat row must be a letter from A to Z.");
                    }
                    Console.Write("Enter Seat Number: ");
                    seatLocation.Number = int.Parse(Console.ReadLine()!);
                    if (seatLocation.Number < 1 || seatLocation.Number > 10)
                    {
                        throw new Exception("Seat number must be between 1 and 100.");
                    }
                    Console.Write("Enter Price: ");
                    ticketPrice = double.Parse(Console.ReadLine()!);
                    if (ticketPrice < 0)
                    {
                        throw new Exception("Price cannot be negative.");
                    }

                    //Console.Write("Enter Discount Amount: ");
                    //Discount = double.Parse(Console.ReadLine()!);
                    //if (Discount < 0)
                    //{
                    //    throw new Exception("Discount cannot be negative.");
                    //}

                    switch(ticketType)
                    {
                        case 0:
                            ticket = new StandardTicket(movieName, ticketPrice, seatLocation);
                            break;
                        case 1:
                            ticket = new VIPTicket(movieName, ticketPrice, true);
                            break;
                        case 2:
                            ticket = new IMAXTicket(movieName, ticketPrice, true);
                            break;
                        default:
                            ticket = new StandardTicket(movieName, ticketPrice, seatLocation);
                            break;
                    }

                    exit = !exit;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Error : {ex.Message}");
                    Console.ResetColor();
                }
            }
            while (!exit);
            Console.WriteLine();
            return ticket;
        }

        
    }
}
