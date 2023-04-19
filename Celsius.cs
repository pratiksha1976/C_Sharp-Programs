using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter temparature in Celcius");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9/5) + 32;
        Console.WriteLine("The equivalent Temparature in Fahrenheit is {0:F1}F", fahrenheit);
    }
}   