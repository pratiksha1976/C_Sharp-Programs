using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class EventBO
    {
        public void EventDisplay(string organizer, List<Event> list)
        {
            List<Event> resultedList = list.Where(e => e.Organizer.Equals(organizer)).ToList();
            
            Console.WriteLine("Events Organized by {0}:", organizer);
            if(resultedList.Count == 0)
            {
                Console.WriteLine("No Event is found for this organizer...");
            }
            else 
            {
                foreach(Event e in resultedList)
                {
                    Console.WriteLine("Event Name: {0}", e.Name);
                    Console.WriteLine("Event Type: {0}", e.Type);
                    Console.WriteLine("Event Cost: {0}", e.Cost);
                }
                
            }
        }
    }
