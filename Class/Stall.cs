using System;

namespace StallCostCalculator
{
    class Stall
    {
        public void ComputeCost(string stallType, int squareFeet)
        {
            int cost = 0;
            if(stallType.Equals("Gold"))
            {
                cost = squareFeet * 100;
            }
            Console.WriteLine(stallType + " costs Rs." + cost);
        }

        public void ComputeCost(string stallType, int squareFeet, int numberOfTV)
        {
            int cost = 0;
            if(stallType.Equals("Diamond"))
            {
                cost = (squareFeet * 150) + (numberOfTV * 100);
            }
            Console.WriteLine(stallType + " costs Rs." + cost);
        }

        public void ComputeCost(string stallType, int squareFeet, bool projectorAvailability)
        {
            int cost = 0;
            if(stallType.Equals("Platinum"))
            {
                cost = squareFeet * 200;
                if(projectorAvailability)
                {
                    cost += 1000;
                }
            }
            Console.WriteLine(stallType + " costs Rs." + cost);
        }
    }
}
