using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Event myevent = new Event();
        Console.WriteLine("Enter the number of events");
        int n = Convert.ToInt32(Console.ReadLine());
        List<Event> eventList = new List<Event>();
         Console.WriteLine("Enter event details in CSV(Event Name,Organiser Name,Event Cost)");
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(',');
            Event e = new Event(input[0], input[1], Convert.ToDouble(input[2]));
            eventList.Add(e);
        }
       myevent.Display(eventList);
    }
}
