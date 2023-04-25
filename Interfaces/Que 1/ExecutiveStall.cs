using System;

class ExecutiveStall : IStall
{
    private string _name;
    private string _details;
    private double _cost;
    private string _ownerName;
    private int _numberOfTVSet;

    public ExecutiveStall(string name, string details, double cost, string ownerName, int numberOfTVSet)
    {
        _name = name;
        _details = details;
        _cost = cost;
        _ownerName = ownerName;
        _numberOfTVSet = numberOfTVSet;
    }

    public void display()
    {
        Console.WriteLine("Stall name:" + _name);
        Console.WriteLine("Details:" + _details);
        Console.WriteLine("Cost:" + _cost.ToString("0.00"));
        Console.WriteLine("Owner:" + _ownerName);
        Console.WriteLine("Number of TV set:" + _numberOfTVSet);
    }
}
