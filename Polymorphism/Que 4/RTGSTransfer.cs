using System;

class RTGSTransfer : FundTransfer
{
    public override void Transfer(string accountNumber, double amount)
    {
        if (amount > 10000)
        {
            Console.WriteLine("The Amount is transferred using RTGS Transfer");
            Console.WriteLine("Rs.{0} is transferred to the Account Number {1} successfully", amount, accountNumber);
        }
        else
        {
            Console.WriteLine("RTGS Transfer can be done for the amount greater than Rs.10000");
        }
    }
}
