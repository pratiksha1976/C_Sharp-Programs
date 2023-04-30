using System;

class SeatBooking
{
    private string seatAvailability;

    public SeatBooking(string seatAvailability)
    {
        this.seatAvailability = seatAvailability;
    }

    public void BookSeat(int seatNumber)
    {
        try
        {
            if (seatAvailability[seatNumber - 1] == '0')
            {
                seatAvailability = seatAvailability.Substring(0, seatNumber - 1) + '1' + seatAvailability.Substring(seatNumber);
                Console.WriteLine("Booked successfully");
            }
            else
            {
                throw new SeatNotAvailableException("Seat booked already");
            }
        }
        catch (IndexOutOfRangeException)
        {
            throw new SeatNotAvailableException("Array index is out of range.");
        }
    }
}
