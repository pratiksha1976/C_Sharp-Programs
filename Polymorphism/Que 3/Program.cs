using System;

public class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter Event Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Detail");
        string detail = Console.ReadLine();
        Console.WriteLine("Enter Organizer");
        string organizer = Console.ReadLine();

        Console.WriteLine("Select Event Type 1.Exhibition 2.StageEvent");
        int eventType = int.Parse(Console.ReadLine());

        switch (eventType) {
            case 1:
                Console.WriteLine("Enter stall count");
                int stallCount = int.Parse(Console.ReadLine());

                Exhibition exhibition = new Exhibition(name, detail, organizer, stallCount);
                Console.WriteLine(exhibition.ToString());
                exhibition.TotalCredit();
                break;

            case 2:
                Console.WriteLine("Enter Total shows");
                int totalShows = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter seats per show");
                int seatsPerShow = int.Parse(Console.ReadLine());

                StageEvent stageEvent = new StageEvent(name, detail, organizer, totalShows, seatsPerShow);
                Console.WriteLine(stageEvent.ToString());
                stageEvent.TotalCredit();
                break;

            default:
                Console.WriteLine("Enter valid choice");
                break;
        }
    }
}
