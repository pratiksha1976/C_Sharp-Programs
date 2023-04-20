Number Pattern

Write a program to print the given pattern.

Input Format:

Input consists of a single integer.

Output Format:

Refer sample outputs. There is a trailing space at the end of each line.
Sample Input 1:  
5
Sample Output 1:

1 2 3 4 5
1 2 3 4
1 2 3
1 2
1

using System;

public class Program {
    public static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = n; i >= 1; i--) {
            for (int j = 1; j <= i; j++) {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}