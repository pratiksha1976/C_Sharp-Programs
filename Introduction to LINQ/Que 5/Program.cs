using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of purchase");
        int n = Convert.ToInt32(Console.ReadLine());

        List<Purchase> purchases = new List<Purchase>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter customer id");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter purchased date");
            DateTime purchasedDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());

            Purchase purchase = new Purchase(customerId, purchasedDate, amount);
            purchases.Add(purchase);
        }

        Console.WriteLine("Start date");
        DateTime startDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("End date");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        var filteredPurchases = from p in purchases
                                where p.PurchasedDate >= startDate && p.PurchasedDate <= endDate
                                select p;


        if (filteredPurchases.Count() == 0)
        {
            Console.WriteLine("No purchase found");
        }
        else
        {
        Console.WriteLine("{0,-10}{1,-15}{2,-10}", "Customer", "PurchasedDate", "Amount");

            foreach (var purchase in filteredPurchases)
            {
                
                Console.WriteLine("{0,-10}{1,-15}{2,-10}", purchase.CustomerId, purchase.PurchasedDate.ToString("yyyy-MM-dd"), purchase.Amount);
            }
        }
    }
}
