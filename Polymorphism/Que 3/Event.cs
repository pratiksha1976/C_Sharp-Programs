using System;

public class Event {
    protected string _name;
    protected string _detail;
    protected string _organizer;

    public Event() {}

    public Event(string name, string detail, string organizer) {
        _name = name;
        _detail = detail;
        _organizer = organizer;
    }

    public virtual  void TotalCredit() {
        Console.WriteLine("Credit Details");
    }
}
