using System;

public class Program
{
    public delegate void RectangleDelegate(double width, double height);

    public static void PrintArea(double width, double height)
    {
        double area = width * height;
        Console.WriteLine($"Area is: {area}");
    }

    public static void PrintPerimeter(double width, double height)
    {
        double perimeter = 2 * (width + height);
        Console.WriteLine($"Perimeter is: {perimeter}");
    }

    public static void Main()
    {
        Console.WriteLine("Enter the width");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height");
        double height = Convert.ToDouble(Console.ReadLine());

        RectangleDelegate rectangleDelegate = new RectangleDelegate(PrintArea);
        rectangleDelegate += PrintPerimeter;
        rectangleDelegate.Invoke(width, height);
    }
}
