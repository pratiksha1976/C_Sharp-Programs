using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Account number:");
        string accountNo = Console.ReadLine();
        Console.WriteLine("Enter the amount to be transferred:");
        double amount = Convert.ToDouble(Console.ReadLine());
        int result = FundTransfer.Validate(accountNo, amount);
        if (result == 1)
        {
            Console.WriteLine("Enter the type of transfer:\n1.NEFT Transfer\n2.IMPS Transfer\n3.RTGS Transfer");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {   
                NEFTTransfer nt = new NEFTTransfer();
                nt.Transfer(accountNo, amount);
            }
            else if (type == 2)
            {
                IMPSTransfer it = new IMPSTransfer();
                it.Transfer(accountNo, amount);
            }
            else if (type == 3)
            {
                RTGSTransfer rt = new RTGSTransfer();
                rt.Transfer(accountNo, amount);
            }
            else
            {
                Console.WriteLine("Invalid Transfer Type");
            }
        }
        else
            Console.WriteLine("Invalid data");
    }
}
