using System;
using System.Collections;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Courses");
        int n = Convert.ToInt32(Console.ReadLine());
        ArrayList courses = new ArrayList();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Course {i + 1} Details");
            Console.WriteLine("Enter the id");
            string id = Console.ReadLine();
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the category");
            string category = Console.ReadLine();
            Console.WriteLine("Enter the price");
            int price = Convert.ToInt32(Console.ReadLine());

            courses.Add(new Course(id, name, category, price));
        }

        var groupedCourses = from Course course in courses
                             group course by course.Category into courseGroup
                             select new { Name = courseGroup.Key, Price = courseGroup.Min(c => c.Price) };

        foreach (var course in groupedCourses)
        {
            Console.WriteLine($"Course {{ Name = {course.Name}, Price = {course.Price} }}");
        }
    }
}
