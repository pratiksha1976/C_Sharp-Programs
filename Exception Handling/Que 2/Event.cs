using System;

public class Event
{
    private string _name;
    private string _type;
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

    public string Organizer
    {
        get { return _organizer; }
        set { _organizer = value; }
    }

    public Event(string name, string type, string organizer)
    {
        _name = name;
        _type = type;
        _organizer = organizer;
    }

    public virtual void Display()
    {
        Console.WriteLine("Event Name: {0}", _name);
        Console.WriteLine("Event organizer: {0}", _organizer);
        Console.WriteLine("Event Type: {0}", _type);
    }
}
