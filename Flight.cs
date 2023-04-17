using System;

public class Flight{
    public static void Main(string[] args){

        Console.WriteLine("Enter Flight name:");
        string flightName=Console.ReadLine();

        Console.WriteLine("Enter Ticket No:");
        int num=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Flight Fare:");
        float fare=float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Travelling Class:");
        char _class=Console.ReadLine()[0];

        Console.WriteLine("Enter Source: ");
       string  source=Console.ReadLine();

        Console.WriteLine("Enter Destination:");
        string desti=Console.ReadLine();

        Console.WriteLine("Flight Details:");
        Console.WriteLine("Flight  Name: "+flightName);
        Console.WriteLine("Ticket No: "+num);
        Console.WriteLine("Flight  Fare: "+fare);
        Console.WriteLine("Class: "+_class);
        Console.WriteLine("Source: "+source);
        Console.WriteLine("Destination: "+desti);
    }
}