using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<HallBooking> hallBookingList = new List<HallBooking>();
        HallBookingBO hallBookingBO = new HallBookingBO();

        // Reading input file and creating hallbooking objects
        using (StreamReader sr = new StreamReader("input.txt"))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                HallBooking hallBooking = hallBookingBO.CreateHallBooking(line);
                hallBookingList.Add(hallBooking);
            }
        }

        // Getting count of events in each hall
        Dictionary<string, int> hallBookingCount = hallBookingBO.HallBookedCount(hallBookingList);

        // Displaying hall name and event count
        Console.WriteLine("Hall details");
        Console.WriteLine("{0,-20} {1,-10}", "Hall name", "Event count");
        foreach (KeyValuePair<string, int> entry in hallBookingCount)
        {
            Console.WriteLine("{0,-20} {1,-10}", entry.Key, entry.Value);
        }
    }
}
