using System;

namespace StallCostCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the stall type");
            string stallType = Console.ReadLine();
            Console.WriteLine("Enter the square feet");
            int squareFeet = int.Parse(Console.ReadLine());
            Stall stall = new Stall();
            if(stallType.Equals("Gold"))
            {
                stall.ComputeCost(stallType, squareFeet);
            }
            else if(stallType.Equals("Diamond"))
            {
                Console.WriteLine("Enter the number of TV");
                int numberOfTV = int.Parse(Console.ReadLine());
                stall.ComputeCost(stallType, squareFeet, numberOfTV);
            }
            else if(stallType.Equals("Platinum"))
            {
                Console.WriteLine("Do you need a projector(yes/no)");
                bool projectorAvailability = Console.ReadLine().Equals("yes");
                stall.ComputeCost(stallType, squareFeet, projectorAvailability);
            }
        }
    }
}
