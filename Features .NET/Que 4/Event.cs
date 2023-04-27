using System;
using System.Collections.Generic;

class Event
{
    private string _eventName;
    private string _organiserName;
    private double _eventCost;

    public Event(){}
    
    public Event(string eventName, string organiserName, double eventCost)
    {
        _eventName = eventName;
        _organiserName = organiserName;
        _eventCost = eventCost;
    }

    public string EventName
    {
        get { return _eventName; }
        set { _eventName = value; }
    }

    public string OrganiserName
    {
        get { return _organiserName; }
        set { _organiserName = value; }
    }

    public double EventCost
    {
        get { return _eventCost; }
        set { _eventCost = value; }
    }

    public override string ToString()
    {
        return $"{_eventName}|{_organiserName}|{_eventCost}";
    }

   public  void Display(List<Event> eventList)

    {
        Console.WriteLine("List of events");
        eventList.ForEach(e => Console.WriteLine(e.ToString()));
    }
}
