using System;
public class SavingAccount : Account
{
    public double _minimumBalance;
    public SavingAccount(string accountNumber, double balance, string accountHolderName, double minimumBalance) : base(accountNumber, balance, accountHolderName)
    {
        _minimumBalance = minimumBalance;
    }
}
//
