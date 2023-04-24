using System;

class NEFTTransfer : FundTransfer
{
    private DateTime _date = DateTime.Now;
    private DateTime _start = DateTime.Parse("09:00:00 AM");
    private DateTime _end = DateTime.Parse("06:00:00 PM");
    
    public override void Transfer(string accountNumber, double amount)
    {
        Console.WriteLine("Enter the Transaction time(hh:mm:ss tt):");
        DateTime transactionTime = DateTime.Parse(Console.ReadLine());

        if (transactionTime.TimeOfDay >= _start.TimeOfDay && transactionTime.TimeOfDay <= _end.TimeOfDay)
        {
            Console.WriteLine("The Amount is transferred using NEFT Transfer");
            Console.WriteLine("Rs.{0} is transferred to the Account Number {1} successfully", amount, accountNumber);
        }
        else
        {
            Console.WriteLine("The Transaction Time is " + transactionTime.ToString("hh:mm:ss tt"));
            Console.WriteLine("NEFT Transfer is applicable between 9.00 AM and 6.00 PM.");
        }
    }
}
