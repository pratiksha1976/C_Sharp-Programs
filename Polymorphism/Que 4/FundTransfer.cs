using System;

abstract class FundTransfer
{
    public abstract void Transfer(string accountNumber, double amount);
    
    public static int Validate(string accountNo, double amount)
    {
        if (accountNo.Length == 10 && amount > 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
