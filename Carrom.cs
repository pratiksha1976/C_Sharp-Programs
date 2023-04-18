using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number of lost team's coins left on board");
        int n = Convert.ToInt32(Console.ReadLine());

        if(n <= 0 || n>9)
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            Console.WriteLine("Has winning team pocketed red [y or n]?");
            char c = Convert.ToChar(Console.ReadLine());

            int points = n;
            if(c=='y')
            {
                points+=5;
            }

            Console.WriteLine("Points won: "+points);
        }
    }
}