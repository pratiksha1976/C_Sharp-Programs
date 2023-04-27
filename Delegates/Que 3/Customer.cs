using System;

public class Customer
{
    private string _firstName;
    private string _lastName;

    // Constructor
    public Customer(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    // Method to display first name
    public void DisplayFirstName()
    {
        Console.WriteLine("First Name: " + _firstName);
    }

    // Method to display last name
    public void DisplayLastName()
    {
        Console.WriteLine("Last Name: " + _lastName);
    }
}
