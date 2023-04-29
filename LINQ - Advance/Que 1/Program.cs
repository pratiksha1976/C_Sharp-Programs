using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Customers :");
            int numOfCustomers = int.Parse(Console.ReadLine());

            List<Customer> customers = new List<Customer>();
            List<Purchase> purchases = new List<Purchase>();

            for (int i = 1; i <= numOfCustomers; i++)
            {
                Console.WriteLine("Enter Id :");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter First Name :");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name :");
                string lastName = Console.ReadLine();

                customers.Add(new Customer(id, firstName, lastName));
            }

            Console.WriteLine("Enter Number of Entry in database :");
            int numOfPurchases = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOfPurchases; i++)
            {
                Console.WriteLine("Enter Customer Id :");
                int customerId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Purchased Date :");
                DateTime purchasedDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Amount :");
                long amount = long.Parse(Console.ReadLine());

                purchases.Add(new Purchase(customerId, purchasedDate, amount));
            }

            var customerGroups = from purchase in purchases
                                 join customer in customers
                                 on purchase.CustomerId equals customer.Id
                                 group purchase by customer into customerPurchases
                                 select new
                                 {
                                     Customer = customerPurchases.Key,
                                     PurchaseCount = customerPurchases.Count()
                                 };

            var favoriteCustomer = customerGroups.OrderByDescending(c => c.PurchaseCount).First();

            Console.WriteLine($"Favorite Customer : {favoriteCustomer.Customer.FirstName}{favoriteCustomer.Customer.LastName}");
        }
    }

