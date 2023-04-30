using System;

public class InvalidDateException : Exception {
    public InvalidDateException(string message) : base(message) {}
}

public class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter the start date(dd/MM/yyyy hh:mm:ss tt):");
        string startDateStr = Console.ReadLine();

        Console.WriteLine("Enter the end date(dd/MM/yyyy hh:mm:ss tt):");
        string endDateStr = Console.ReadLine();

        try {
            DateTime startDate = DateTime.ParseExact(startDateStr, "dd/MM/yyyy hh:mm:ss tt", null);
            DateTime endDate = DateTime.ParseExact(endDateStr, "dd/MM/yyyy hh:mm:ss tt", null);

            Console.WriteLine("Starting Date: " + startDate.ToString("dd/MM/yyyy hh:mm:ss tt"));
            Console.WriteLine("Ending Date: " + endDate.ToString("dd/MM/yyyy hh:mm:ss tt"));
        } catch (FormatException) {
            Console.WriteLine("Invalid Date Format...");
        } catch (InvalidDateException ex) {
            Console.WriteLine(ex.Message);
        }
    }
}
