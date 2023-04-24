using System;

public class TicketBooking
{
    public void MakePayment(double amount)
    {
        Console.WriteLine("You have selected the Cash payment mode");
        Console.WriteLine("The Amount is Rs." + amount + ".");
    }

    public void MakePayment(string walletNumber, double amount)
    {
        Console.WriteLine("You have selected the Wallet payment mode");
        Console.WriteLine("Wallet Number: " + walletNumber);
        Console.WriteLine("The Amount is Rs." + amount + ".");
    }

    public void MakePayment(string creditCard, string ccv, string name, double amount)
    {
        Console.WriteLine("You have selected the Credit Card payment mode");
        Console.WriteLine("CreditCard Number: " + creditCard);
        Console.WriteLine("Validity Date: " + ccv);
        Console.WriteLine("Card Holder Name: " + name);
        Console.WriteLine("The Amount is Rs." + amount + ".");
    }
}
