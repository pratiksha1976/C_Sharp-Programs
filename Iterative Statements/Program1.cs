Sum of digits
Write a program using a while loop to find the sum of digits of a given number.
Input Format :
Input consists of a positive integer value.
Output Format :
The output consists of the sum of digits in the input value.

Refer to Sample Input and Output for further details.

Sample Input 1 :

Enter the value :

1345

Sample Output 1 :

Sum of digits in 1345 is 13

using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Enter the value :");
    int num = int.Parse(Console.ReadLine());
    int temp=num;
    int sum = 0;
    while (temp > 0) {
      sum += temp % 10;
      temp /= 10;
    }
    Console.WriteLine("Sum of digits in {0} is {1}", num, sum);
  }
}