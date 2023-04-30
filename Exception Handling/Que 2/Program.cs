using System;

class Program
{
    static void Main(string[] args)
    {
        string name="" ,type="", organizer="";
        int noOfStalls;

        try
        {
            Console.WriteLine("Enter the Event Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter the Event Organizer:");
            organizer = Console.ReadLine();

            Console.WriteLine("Enter the Event Type(Exhibition/Others):");
            type = Console.ReadLine();

            if (type == "Exhibition")
            {
                Console.WriteLine("Enter No.of Stalls:");
                noOfStalls = int.Parse(Console.ReadLine());

                Exhibition exhibition = new Exhibition(name, type, organizer, noOfStalls);
                exhibition.Display();
            }
            else if (type == "Others")
            {
                throw new NullReferenceException("Null Reference Exception... Event Type is not Exhibition");
            }
            else
            {
                throw new Exception("Invalid event type...");
            }
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
            Event ev = new Event(name, type, organizer);
            ev.Display();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
