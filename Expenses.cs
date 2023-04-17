using System;

class Expenses {
    static void Main(string[] args) {
        // Collect expenses
        Console.WriteLine("Enter branding expenses");
        double brandingExpenses = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter travel expenses");
        double travelExpenses = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter food expenses");
        double foodExpenses = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter logistics expenses");
        double logisticsExpenses = Convert.ToDouble(Console.ReadLine());

        // Calculate total expenses
        double totalExpenses = brandingExpenses + travelExpenses + foodExpenses + logisticsExpenses;

        // Calculate expense percentages
        double brandingPercentage = (brandingExpenses / totalExpenses) * 100;
        double travelPercentage = (travelExpenses / totalExpenses) * 100;
        double foodPercentage = (foodExpenses / totalExpenses) * 100;
        double logisticsPercentage = (logisticsExpenses / totalExpenses) * 100;

        // Display results
        Console.WriteLine("Total expenses: Rs." + totalExpenses.ToString("0.00"));
        Console.WriteLine("Branding expenses percentage: " + brandingPercentage.ToString("0.00") + "%");
        Console.WriteLine("Travel expenses percentage: " + travelPercentage.ToString("0.00") + "%");
        Console.WriteLine("Food expenses percentage: " + foodPercentage.ToString("0.00") + "%");
        Console.WriteLine("Logistics expenses percentage: " + logisticsPercentage.ToString("0.00") + "%");
    }
}
