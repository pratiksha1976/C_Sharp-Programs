using System;
public class Account
{
    public string _accountNumber;
    public double _balance;
    public string _accountHolderName;

    public Account(string accountNumber, double balance, string accountHolderName)
    {
        _accountNumber = accountNumber;
        _balance = balance;
        _accountHolderName = accountHolderName;
    }
}
