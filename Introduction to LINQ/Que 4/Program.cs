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

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Course {i} Details");
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

            Console.WriteLine("Enter the price limit");
            Console.WriteLine("Enter the min limit");
            int minLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the max limit");
            int maxLimit = Convert.ToInt32(Console.ReadLine());

            var filteredCourses = from Course course in courses
                                  where course.Price >= minLimit && course.Price <= maxLimit
                                  select course;

            if (filteredCourses.Count() == 0)
            {
                Console.WriteLine("No course available in this limit");
            }
            else
            {
                Console.WriteLine($"Courses which is in limit {minLimit} to {maxLimit}");
                int cnt=1;
                foreach (Course course in filteredCourses)
                {
                    Console.WriteLine($"Course {cnt} Details");
                    Console.WriteLine($"Course Id : {course.Id}");
                    Console.WriteLine($"Course Name : {course.Name}");
                    Console.WriteLine($"Course Category : {course.Category}");
                    Console.WriteLine($"Course Price : {course.Price}");
                    cnt++;
                }
            }
        }
    }
