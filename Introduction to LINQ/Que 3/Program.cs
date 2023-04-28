using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            int numStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 1; i <= numStudents; i++)
            {
                Console.WriteLine($"Student {i} Details");
                Console.WriteLine("Enter the id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the age");
                int age = int.Parse(Console.ReadLine());

                students.Add(new Student(id, name, age));
            }

            var sortedStudents = from student in students
                                 orderby student.Name
                                 select student.Name;

            Console.WriteLine("Sorted student names");

            foreach (string name in sortedStudents)
            {
                Console.WriteLine(name);
            }
        }
    }

