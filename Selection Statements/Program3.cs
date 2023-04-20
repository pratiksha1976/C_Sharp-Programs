// Maximum of Three Numbers

// Write a  program to find the maximum of three numbers.

// Input Format:

// Input consists of three lines. Each line consists of an integer.

// Output Format:

// The output consists of a single line, with the value of a maximum number.

// Sample Input 1:

// 3

// 5

// 1

// Sample Output 1:

// 5 is the maximum number

using System;

class Program {
  public static void Main (string[] args) {
    int num1 = int.Parse(Console.ReadLine());;
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());

    int max = num1;

    if (num2 > max) {
      max = num2;
    }

    if (num3 > max) {
      max = num3;
    }
    Console.WriteLine($"{max} is the maximum number");
  }
}