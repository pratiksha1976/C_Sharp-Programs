using System;

public class StageEvent : Event
{
    private string _showType;

    public StageEvent() { }

    public StageEvent(string _name, DateTime _date, string _type, string _organizer, string _showType) : base(_name, _date, _type, _organizer)
    {
        this._showType = _showType;
    }

    public void Display()
    {
        Console.WriteLine("Event Name: {0}", _name);
        Console.WriteLine("Event Date: {0:dd/MM/yyyy}", _date);
        Console.WriteLine("Event Organizer: {0}", _organizer);
        Console.WriteLine("Event Type: {0}", _type);
        Console.WriteLine("Show Type: {0}", _showType);
    }
}
