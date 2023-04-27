using System;
using System.Collections.Generic;


class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of accounts :");
            int n = int.Parse(Console.ReadLine());

            Account[] accounts = new Account[n];
            Console.WriteLine("Enter accounts :");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Account Number :");
                string aNumber = Console.ReadLine();
                Console.WriteLine("Premium :");
                double premium = double.Parse(Console.ReadLine());
                Console.WriteLine("Discount Percent :");
                int discountPercent = int.Parse(Console.ReadLine());
                accounts[i] = new Account(aNumber, premium, discountPercent);
            }

            Console.WriteLine("Account Details :");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account.ToString());
            }
        }
    }
