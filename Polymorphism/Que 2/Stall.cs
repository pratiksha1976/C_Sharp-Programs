using System;

namespace Stalls
{
    class Stall
    {
        public void ComputeCost(string stallType, int squareFeet)
        {
            if (stallType == "Gold")
            {
                Console.WriteLine("Gold costs Rs." + (squareFeet * 100));
            }
        }

        public void ComputeCost(string stallType, int squareFeet, int numberOfTV)
        {
            if (stallType == "Diamond")
            {
                Console.WriteLine("Diamond costs Rs." + (squareFeet * 150 + numberOfTV * 100));
            }
        }

        public void ComputeCost(string stallType, int squareFeet, bool projectorAvailability)
        {
            if (stallType == "Platinum")
            {
                int cost = squareFeet * 200;
                if (projectorAvailability)
                {
                    cost += 1000;
                }
                Console.WriteLine("Platinum costs Rs." + cost);
            }
        }
    }
}
