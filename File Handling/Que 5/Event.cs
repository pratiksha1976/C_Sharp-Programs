using System;
using System.Collections.Generic;
using System.IO;

class Event
{
    private string _name;
    private string _type;
    private double _cost;
    private string _organizer;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public double Cost
    {
        get { return _cost; }
        set { _cost = value; }
    }

    public string Organizer
    {
        get { return _organizer; }
        set { _organizer = value; }
    }

    public Event(string name, string type, double cost, string organizer)
    {
        _name = name;
        _type = type;
        _cost = cost;
        _organizer = organizer;
    }
}
