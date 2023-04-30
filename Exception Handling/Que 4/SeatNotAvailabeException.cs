using System;

class SeatNotAvailableException : Exception
{
    public SeatNotAvailableException(string message) : base(message)
    {
    }
}
