using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Event Name:");
        string _name = Console.ReadLine();
        Console.WriteLine("Enter the Event Date:");
        DateTime _date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.WriteLine("Enter the Event Organizer:");
        string _organizer = Console.ReadLine();
        Console.WriteLine("Enter the Event Type(Exhibition/Stage Event):");
        string _type = Console.ReadLine();

        if (_type.Equals("Exhibition"))
        {
            Console.WriteLine("Enter the Stall Type:");
            string _stallType = Console.ReadLine();
            Exhibition e = new Exhibition(_name, _date, _type, _organizer, _stallType);
            e.Display();
        }
        else if (_type.Equals("Stage Event"))
        {
            Console.WriteLine("Enter the Show Type:");
            string _showType = Console.ReadLine();
            StageEvent s = new StageEvent(_name, _date, _type, _organizer, _showType);
            s.Display();
        }
        else
        {
            Console.WriteLine("Enter the correct Event Type and try again...");
        }
    }
}
