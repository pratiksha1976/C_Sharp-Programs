// Finding Odd or Even

// Write a program to find whether a given integer is an odd or even number.

//  Input and Output Format:

// Input consists of a single integer.

// The output consists of a single line, which represents whether it is an even number or not.

using System;

class Program {
    public static void Main(String[] args) {
        //Fill your code here
        int num=int.Parse(Console.ReadLine());

        if(num%2==0)
        {
            Console.WriteLine(num+" is an even number");
        }
        else{
            Console.WriteLine(num+" is an odd number");

        }
    }
}