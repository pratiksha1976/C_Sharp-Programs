using System;

class Program
{
    static void Main(string[] args)
    {
        TicketBooking ticketBooking = new TicketBooking();

        Console.WriteLine("Enter the mode of Payment:");
        Console.WriteLine("1.Cash Payment");
        Console.WriteLine("2.Wallet Payment");
        Console.WriteLine("3.Credit Card");

        int paymentMode = Convert.ToInt32(Console.ReadLine());

        switch (paymentMode)
        {
            case 1:
                Console.WriteLine("Enter the Amount of Payment:");
                double cashAmount = Convert.ToDouble(Console.ReadLine());
                ticketBooking.MakePayment(cashAmount);
                break;
            case 2:
                Console.WriteLine("Enter the Wallet Number:");
                string walletNumber = Console.ReadLine();
                Console.WriteLine("Enter the Amount of Payment:");
                double walletAmount = Convert.ToDouble(Console.ReadLine());
                ticketBooking.MakePayment(walletNumber, walletAmount);
                break;
            case 3:
                Console.WriteLine("Enter the Credit Card Number:");
                string creditCard = Console.ReadLine();
                Console.WriteLine("Enter the Validity Date(dd/MM/yyyy):");
                string ccv = Console.ReadLine();
                Console.WriteLine("Enter the Card Holder Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Amount of Payment:");
                double creditCardAmount = Convert.ToDouble(Console.ReadLine());
                ticketBooking.MakePayment(creditCard, ccv, name, creditCardAmount);
                break;
            default:
                Console.WriteLine("Please select the correct mode of payment...");
                break;
        }

        Console.ReadKey();
    }
}
