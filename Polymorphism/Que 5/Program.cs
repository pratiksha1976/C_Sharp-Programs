
using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Shapes");
        Console.WriteLine("1.Square");
        Console.WriteLine("2.Rectangle");
        Console.WriteLine("3.Circle");
        Console.WriteLine("Enter your choice");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the side of the square");
                double side = double.Parse(Console.ReadLine());
                Square square = new Square(side);
                Console.WriteLine($"Perimeter of square is {square.Perimeter():0.00}");
                break;

            case 2:
                Console.WriteLine("Enter the length of the rectangle");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle");
                double width = double.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(length, width);
                Console.WriteLine($"Perimeter of rectangle is {rectangle.Perimeter():0.00}");
                break;

            case 3:
                Console.WriteLine("Enter the radius of the circle");
                double radius = double.Parse(Console.ReadLine());
                Circle circle = new Circle(radius);
                Console.WriteLine($"Perimeter of circle is {circle.Perimeter():0.00}");
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}
