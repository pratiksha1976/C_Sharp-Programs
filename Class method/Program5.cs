using System;

namespace InnovativeMinds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int den = int.Parse(Console.ReadLine());
            
            PrintValue(num, den);
        }
        
        static void PrintValue(int num, int den)
        {
            if (num == 0)
            {
                Console.WriteLine("0");
                return;
            }
            
            int gcd = GCD(num, den);
            num /= gcd;
            den /= gcd;
            
            if (num < den)
            {
                Console.WriteLine($"{num}/{den}");
            }
            else
            {
                int whole = num / den;
                num %= den;
                if (num == 0)
                {
                    Console.WriteLine(whole);
                }
                else
                {
                    Console.WriteLine($"{whole} {num}/{den}");
                }
            }
        }
        
        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return GCD(b, a % b);
        }
    }
}
