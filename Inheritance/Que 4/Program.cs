using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of accounts:");
        int numberOfAccounts = Convert.ToInt32(Console.ReadLine());

        List<FixedAccount> fixedAccountList = new List<FixedAccount>();
        AccountBO accountBO = new AccountBO();

        for (int i = 1; i <= numberOfAccounts; i++)
        {
            Console.WriteLine("Enter account-{0} Detail:", i);
            string accountDetail = Console.ReadLine();
            FixedAccount fixedAccount = accountBO.CreateAccountDetail(accountDetail);
            fixedAccountList.Add(fixedAccount);
        }

        accountBO.DisplayAccountDetails(fixedAccountList);
    }
}
