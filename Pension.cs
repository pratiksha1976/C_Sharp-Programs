using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Has the player represented for India[y or n]?");
        char playedForIndia = char.Parse(Console.ReadLine());

        double  amoubtRecived = 0;

        if(playedForIndia == 'y')
        {
            Console.WriteLine("Enter the number of Test matches he has played");
            int testMatches = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of ODI matches he has played");
            int odiMatches = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of man of the matches he has won");
            int momAward = int.Parse(Console.ReadLine());

            if(testMatches > 10 && odiMatches > 100)
            {
                amoubtRecived =50000;
            }
            else if(testMatches > 10)
            {
                amoubtRecived = 25000;
            }
            else if(odiMatches >100)
            {
                amoubtRecived = 15000;
            }
            else{
                amoubtRecived = 10000;
            }

            amoubtRecived += momAward * 0.25*amoubtRecived;
        }

        else{
            Console.WriteLine("Has he played IPL[y or n]?");
            char playedIPL = char.Parse(Console.ReadLine());
            
            if(playedIPL =='y')
            {
                amoubtRecived =8000;
            }
            else{
                amoubtRecived=7000;
                }
            
          }

          Console.WriteLine("Amount received as pension: Rs.{0.F1}",amoubtRecived);
    }

}