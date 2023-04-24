using System;

class IMPSTransfer : FundTransfer
{
    public override void Transfer(string accountNumber, double amount)
    {
        Console.WriteLine("The Amount is transferred using IMPS Transfer");
        Console.WriteLine("Rs.{0} is transferred to the Account Number {1} successfully", amount, accountNumber);
        double serviceCharge = amount * 0.02;
        Console.WriteLine("The Service charge for this transaction is Rs." + serviceCharge);
    }
}
