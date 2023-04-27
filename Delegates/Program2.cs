using System;

public class Program
{
    public delegate void CalculateDelegate(int num1, int num2);

    public static void Addition(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine($"The sum is : {sum}");
    }

    public static void Subtract(int num1, int num2)
    {
        int subtraction = num1 - num2;
        Console.WriteLine($"The subtraction is : {subtraction}");
    }

    public static void Main()
    {
        Console.WriteLine("Enter the num1");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the num2");
        int num2 = Convert.ToInt32(Console.ReadLine());

        CalculateDelegate calculateDelegate = new CalculateDelegate(Addition);
        calculateDelegate += Subtract;
        calculateDelegate.Invoke(num1, num2);
    }
}
