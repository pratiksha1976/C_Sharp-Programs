using System;

class Program
{
    // Delegate to display customer names
    public delegate void NameDelegate();

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter the last name:");
        string lastName = Console.ReadLine();

        Customer customer = new Customer(firstName, lastName);

        Console.WriteLine("Customer Details");
        NameDelegate nameDelegate = customer.DisplayFirstName;
        nameDelegate += customer.DisplayLastName;
        nameDelegate.Invoke();
    }
}
