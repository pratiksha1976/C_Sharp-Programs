Palindromic Prize

A customer in the Personalised Gift Store is awarded a prize when their bill number is a 3-digit palindrome.Write a program for identifying the prize winners.

 

Input Format:

Input consists of a number that corresponds to the bill number.


Output Format:

The output consists of a string that is either 'yes' or 'no'. The output is 'yes' when the customer receives the prize and is 'no' otherwise.

 

Sample Input 1:

565

Sample Output 1:

yes


using System;

class Program {
    static void Main(string[] args) {
        // Read the input bill number
        int billNumber = int.Parse(Console.ReadLine());
        
        
        int digit1 = billNumber / 100;
        int digit2 = (billNumber / 10) % 10;
        int digit3 = billNumber % 10;
        
        if (digit1 == digit3) {
            Console.WriteLine("yes");
        } else {
            Console.WriteLine("no");
        }
    }
}