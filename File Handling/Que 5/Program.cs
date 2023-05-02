using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of events");
        int n = int.Parse(Console.ReadLine());

        List<Event> eventList = new List<Event>();

        Console.WriteLine("Enter the event details");

        for (int i = 0; i < n; i++)
        {
            string[] eventDetails = Console.ReadLine().Split(',');
            string name = eventDetails[0];
            string type = eventDetails[1];
            double cost = double.Parse(eventDetails[2]);
            string organizer = eventDetails[3];

            Event e = new Event(name, type, cost, organizer);

            if (!eventList.Contains(e))
            {
                eventList.Add(e);
            }
        }

        EventBO eventBO = new EventBO();
        eventBO.WriteEvents(eventList);

        Console.WriteLine("Event Details is written in the file");
    }
}




