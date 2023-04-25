using System;

class GoldStall : IStall
{
    private string _name;
    private string _details;
    private double _cost;
    private string _ownerName;

    public GoldStall(string name, string details, double cost, string ownerName)
    {
        _name = name;
        _details = details;
        _cost = cost;
        _ownerName = ownerName;
    }

    public void display()
    {
        Console.WriteLine("Stall name:" + _name);
        Console.WriteLine("Details:" + _details);
        Console.WriteLine("Cost:" + _cost.ToString("0.00"));
        Console.WriteLine("Owner:" + _ownerName);
    }
}
