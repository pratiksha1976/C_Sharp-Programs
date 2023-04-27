using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Event
{
    private string _name;
    private string _type;
    private string _organizer;

    public Event(string name, string type, string organizer)
    {
        _name = name;
        _type = type;
        _organizer = organizer;
    }

    public string Name { get { return _name; } }
    public string Type { get { return _type; } }
    public string Organizer { get { return _organizer; } }

    public override string ToString()
    {
        return string.Format("{0,-15}{1,-15}{2,-15}", _name, _type, _organizer);
    }
}
