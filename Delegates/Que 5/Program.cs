using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of halls:");
        int numHalls = Convert.ToInt32(Console.ReadLine());
        List<Hall> hallList = new List<Hall>();
        for (int i = 1; i <= numHalls; i++)
        {
            Console.WriteLine("Enter hall-{0} details:", i);
            string hallDetail = Console.ReadLine();
            Hall hall = Hall.CreateHall(hallDetail);
            hallList.Add(hall);
        }
        Console.WriteLine("Enter the minimum price to filter:");
        double minPrice = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the maximum price to filter:");
        double maxPrice = Convert.ToDouble(Console.ReadLine());
        Predicate<double> costPredicate = cost => cost >= minPrice && cost <= maxPrice;
        List<Hall> filteredList = Hall.FilterHall(hallList, costPredicate);
        Hall.DisplayHallDetails(filteredList);
    }
}
