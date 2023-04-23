using System;
public class FixedAccount : SavingAccount
{
    public int _lockingPeriod;
    public FixedAccount(string accountNumber, double balance, string accountHolderName, double minimumBalance, int lockingPeriod) : base(accountNumber, balance, accountHolderName, minimumBalance)
    {
        _lockingPeriod = lockingPeriod;
    }
}
