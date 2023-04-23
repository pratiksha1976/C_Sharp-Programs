using System;
using System.Collections.Generic;

public class AccountBO
{
    public FixedAccount CreateAccountDetail(string detail)
    {
        string[] detailArray = detail.Split(',');
        string accountNumber = detailArray[0];
        double balance = Convert.ToDouble(detailArray[1]);
        string accountHolderName = detailArray[2];
        double minimumBalance = Convert.ToDouble(detailArray[3]);
        int lockingPeriod = Convert.ToInt32(detailArray[4]);

        return new FixedAccount(accountNumber, balance, accountHolderName, minimumBalance, lockingPeriod);
    }

    public void DisplayAccountDetails(List<FixedAccount> fixedAccountList)
    {
        Console.WriteLine("{0,-20} {1,-10} {2,-20} {3,-20} {4}", "Account Number", "Balance", "Account holder name", "Minimum balance", "Locking period");

        foreach (FixedAccount fixedAccount in fixedAccountList)
        {
            Console.WriteLine("{0,-20} {1,-10:F1} {2,-20} {3,-20:F1} {4}", fixedAccount._accountNumber, fixedAccount._balance, fixedAccount._accountHolderName, fixedAccount._minimumBalance, fixedAccount._lockingPeriod);
        }
    }
}
