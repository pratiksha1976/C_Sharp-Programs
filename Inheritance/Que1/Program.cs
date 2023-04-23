using System;

namespace BankAccountDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Details(HolderName,Account Number,IFSC code,Contact Number)");

            // Read user details from input
            string[] userDetails = Console.ReadLine().Split(',');

            // Parse user details into variables
            string holderName = userDetails[0];
            long accountNumber = long.Parse(userDetails[1]);
            string ifscCode = userDetails[2];
            long contactNumber = long.Parse(userDetails[3]);

            // Prompt user for account type
            Console.WriteLine("Enter Account Type");

            // Read account type from input
            string accountType = Console.ReadLine();

            if (accountType.ToLower() == "saving")
            {
                // Prompt user for interest rate
                Console.WriteLine("Enter Interest Rate");

                // Read interest rate from input
                double interestRate = double.Parse(Console.ReadLine());

                // Create SavingAccount object and display account details
                SavingAccount sa = new SavingAccount(holderName, accountNumber, ifscCode, contactNumber, interestRate);
                sa.Display();
            }
            else if (accountType.ToLower() == "current")
            {
                // Prompt user for organization name and TIN number
                Console.WriteLine("Enter organization Name");
                string organizationName = Console.ReadLine();
                Console.WriteLine("Enter TIN number");
                long tin = long.Parse(Console.ReadLine());

                // Create CurrentAccount object and display account details
                CurrentAccount ca = new CurrentAccount(holderName, accountNumber, ifscCode, contactNumber, organizationName, tin);
                ca.Display();
            }
            else
            {
                // Display error message for invalid account type
                Console.WriteLine("Enter valid Account Type");
            }
        }
    }
}
