using System;

namespace Stalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Stall stall = new Stall();

            Console.WriteLine("Enter the stall type");
            string stallType = Console.ReadLine();

            Console.WriteLine("Enter the square feet");
            int squareFeet = Convert.ToInt32(Console.ReadLine());

            if (stallType == "Gold")
            {
                stall.ComputeCost(stallType, squareFeet);
            }
            else if (stallType == "Diamond")
            {
                Console.WriteLine("Enter the number of TV");
                int numberOfTV = Convert.ToInt32(Console.ReadLine());
                stall.ComputeCost(stallType, squareFeet, numberOfTV);
            }
            else if (stallType == "Platinum")
            {
                Console.WriteLine("Do you need a projector(yes/no)");
                string input = Console.ReadLine();
                bool projectorAvailability = input.ToLower() == "yes";
                stall.ComputeCost(stallType, squareFeet, projectorAvailability);
            }
            else
            {
                Console.WriteLine("Invalid stall type");
            }
        }
    }
}
