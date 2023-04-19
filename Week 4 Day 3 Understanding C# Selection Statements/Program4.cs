// Finding Leap Year

// Write a program to check whether a given year is a leap year or not.

// Input Format:

// Input consists of a single integer.

// Output Format:

// The output consists of a single line. Refer to sample output for details.

// Sample Input 1:

// 1988

// Sample Output 1:

// 1988 is a leap year

// Sample Input 2:

// 1994

// Sample Output 2:

// 1994 is not a leap year

using System;

class Program{
  public static void Main (string[] args) {

    int year = int.Parse(Console.ReadLine());

    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
      Console.WriteLine($"{year} is a leap year");
    }
    else {
      Console.WriteLine($"{year} is not a leap year");
    }
  }
}