Number Pattern - Reverse

Write a program to print the given pattern.

Input Format:

Input consists of a single integer.

Output Format:

Refer sample outputs. There is a trailing space at the end of each line.
Sample Input:
5
Sample Output:
5 4 3 2 1
4 3 2 1
3 2 1
2 1
1

using System;

public class Program {
    public static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = n; i >= 1; i--) {
            for (int j = i; j >= 1; j--) {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
