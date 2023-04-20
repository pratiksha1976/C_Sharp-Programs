Factorial Calculation

Write a program to find the factorial of a given number.

Input Format:

Input consists of a single integer, n.

Output Format:

Output consists of a single integer which corresponds to n!

Sample Input 1:
4
Sample Output 1:
24

using System;

public class Program {
  public static void Main() {
    
    int num = int.Parse(Console.ReadLine());
    int fact = 1;
    for (int i = 1; i <= num; i++) {
      fact *= i;
    }
    Console.WriteLine( fact);
  }
}

 