Reversing a number

Write a program to reverse the digits of a number.

Input Format :

Input consists of a positive integer value.

Output Format :

The output consists of the reverse of the given number.

Refer to Sample Input and Output for further details.

[All text in bold corresponds to input and the rest corresponds to output.]

Sample Input and Output 1 :

Enter the number :
5642
Reverse of the number is 2465
 

Sample Input and Output 2 :

Enter the number :
1000
Reverse of the number is 1

using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Enter the number :");
    int num = int.Parse(Console.ReadLine());
    int reverse = 0;
    while (num > 0) {
      reverse = reverse * 10 + num % 10;
      num /= 10;
    }
    Console.WriteLine("Reverse of the number is {0}", reverse);
  }
}