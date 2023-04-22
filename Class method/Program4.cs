using System;

namespace RectangleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle");
            int width = int.Parse(Console.ReadLine());

            Rectangle rect = new Rectangle(length, width);
            rect.Display();

            Console.WriteLine("Enter the new dimension");
            int d = int.Parse(Console.ReadLine());

            rect = rect.DimensionChange(d);
            rect.Display();
        }
    }
}
