using System;

public class Program
{
static void Main(string[] args)
{
Console.WriteLine("1. Exhibition");
Console.WriteLine("2. Stage Event");
Console.WriteLine("Enter the choice:");
int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the event name:");
    string name = Console.ReadLine();

    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the number of stalls:");
            int noOfStall = Convert.ToInt32(Console.ReadLine());

            Exhibition exhibition = new Exhibition(name, "Exhibition", noOfStall);
            Console.WriteLine($"Event name:{exhibition.Name}");
            Console.WriteLine($"Event type:{exhibition.Type}");
            Console.WriteLine($"Total revenue amount : {exhibition.ProjectedRevenue():F1}");
            break;

        case 2:
            Console.WriteLine("Enter the number of seats:");
            int noOfSeats = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of shows:");
            int noOfShows = Convert.ToInt32(Console.ReadLine());

            StageEvent stageEvent = new StageEvent(name, "Stage Event", noOfSeats, noOfShows);
            Console.WriteLine($"Event name:{stageEvent.Name}");
            Console.WriteLine($"Event type:{stageEvent.Type}");
            Console.WriteLine($"Total revenue amount : {stageEvent.ProjectedRevenue():F1}");
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}
}
