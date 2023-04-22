using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the customer details");

        // Obtain customer details from user
        Console.WriteLine("Enter the  id :");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the name :");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the email :");
        string email = Console.ReadLine();

        Console.WriteLine("Enter the address :");
        string address = Console.ReadLine();

        Console.WriteLine("Enter the purpose :");
        string purpose = Console.ReadLine();

        Console.WriteLine("Enter the other customer details :");
        string otherDetails = Console.ReadLine();

        // Create an object for Customer class
        Customer customer = new Customer();

        // Set the customer details using the properties
        customer.Id = id;
        customer.Name = name;
        customer.Email = email;
        customer.Address = address;
        customer.Purpose = purpose;
        customer.OtherDetails = otherDetails;

        // Call the Display method in Customer class
        customer.Display();

        Console.ReadLine();
    }
}
