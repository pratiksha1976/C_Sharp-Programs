using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the item type name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the cost per day");
            double costPerDay = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the deposit");
            double deposit = double.Parse(Console.ReadLine());

            ItemType item = new ItemType();
            item.Name = name;
            item.CostPerDay = costPerDay;
            item.Deposit = deposit;

            item.Display();
        }
    }

