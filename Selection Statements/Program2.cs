// Checking Divisibility By 7 and 3

// Write a program to find whether a given number is divisible by both 7 and 3.

// Input Format:

// Input consists of a single integer.

// Output Format:

// Output consists of a single line. Refer sample output for the format.

// Sample Input 1:

// 21

// Sample Output 1 :

// 21 is divisible by both 7 and 3

using System;

class Program {
    public static void Main(String[] args) {
        //Fill your code here
        int num=int.Parse(Console.ReadLine());

        if(num%7==0 && num%3==0){
            Console.WriteLine(num+" is divisible by both 7 and 3");
    }
        else{
            Console.WriteLine(num+" is not divisible by both 7 and 3");

        }

    }
}
