namespace Cinema_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string movieName = default!;
            int ticketType = default;
            SeatLocation seatLocation = new();
            double ticketPrice = default;
            double Discount = default;
            
            ConsoleHelper.PartOneBookingSummary(movieName!, ticketType, seatLocation, ticketPrice, Discount);
        }
    }
}
