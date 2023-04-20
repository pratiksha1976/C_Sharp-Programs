using System;

public class Customer
{
    private int _id;
    private string _name;
    private string _email;
    private string _address;
    private string _purpose;
    private string _otherDetails;

    // Properties
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string Purpose
    {
        get { return _purpose; }
        set { _purpose = value; }
    }

    public string OtherDetails
    {
        get { return _otherDetails; }
        set { _otherDetails = value; }
    }

    // Method to display the customer details
    public void Display()
    {
        Console.WriteLine("\nCustomer details are :");
        Console.WriteLine("ID :" + Id);
        Console.WriteLine("Name :" + Name);
        Console.WriteLine("Email :" + Email);
        Console.WriteLine("Address :" + Address);
        Console.WriteLine("Purpose :" + Purpose);
        Console.WriteLine("Other details :" + OtherDetails);
    }
}
