using System;
using System.Collections.Generic;
using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            List<Event> eventList = new List<Event>();
            using( StreamReader sr = new StreamReader("input.txt")){
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string nm = line.Substring(0,25).Trim();
                    string type = line.Substring(25,15).Trim();
                    double cost = double.Parse(line.Substring(39,10).Trim());
                    string orgainzer = line.Substring(49,10).Trim();
                    Event e = new Event(nm, type, cost, orgainzer);
                    eventList.Add(e);
                }
                sr.Close();
            }

            Console.WriteLine("Enter the organizer name to view:");
            string name = Console.ReadLine();

            EventBO ebo = new EventBO();
            
            ebo.EventDisplay(name, eventList);
            
        }
    }
