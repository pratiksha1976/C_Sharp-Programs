using System;

public class Exhibition : Event
{
    private int _noOfStalls;

    public int NoOfStalls
    {
        get { return _noOfStalls; }
        set { _noOfStalls = value; }
    }

    public Exhibition(string name, string type, string organizer, int noOfStalls) : base(name, type, organizer)
    {
        _noOfStalls = noOfStalls;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("No of Stalls: {0}", _noOfStalls);
    }
}
