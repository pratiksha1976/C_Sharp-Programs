Finding Prime Number

Write a program to find whether a given number is prime or not.
Input Format:

Input consists of a single integer.

Output Format:

The output should display whether the input is “Prime” or “Not prime”.
Refer sample input and output for formatting specifications.

Sample Input 1:
13
Sample Output1:
Prime

using System;

public class Program {
  public static void Main() {
    int num = int.Parse(Console.ReadLine());
    bool isPrime = true;
    if (num == 1) {
      isPrime = false;
    }
    for (int i = 2; i <= Math.Sqrt(num); i++) {
      if (num % i == 0) {
        isPrime = false;
        break;
      }
    }
    if (isPrime) {
      Console.WriteLine("Prime");
    } else {
      Console.WriteLine("Not prime");
    }
  }
}
