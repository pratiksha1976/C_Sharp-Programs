using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class EventBO
{
    public void WriteEvents(List<Event> list)
    {
        StreamWriter sw = new StreamWriter("output.csv");

        foreach (Event e in list)
        {
            sw.WriteLine("{0},{1},{2},{3}", e.Name, e.Type, e.Cost, e.Organizer);
        }

        sw.Close();
    }
}
