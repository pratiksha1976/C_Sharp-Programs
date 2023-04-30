using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the booking details");
        string seatAvailability = Console.ReadLine();
        SeatBooking booking = new SeatBooking(seatAvailability);
        Console.WriteLine("Enter the seat number to book");
        int seatNumber = int.Parse(Console.ReadLine());
        try
        {
            booking.BookSeat(seatNumber);
        }
        catch (SeatNotAvailableException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
