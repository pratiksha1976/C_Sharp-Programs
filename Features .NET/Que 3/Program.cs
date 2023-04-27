using System;
using System.Collections.Generic;
using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students :");
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            Console.WriteLine("Enter the students :");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Name :");
                string name = Console.ReadLine();
                Console.WriteLine("ProblemCount :");
                int problemCount = int.Parse(Console.ReadLine());

                students.Add(new Student(name, problemCount));
            }

            var lessThan100 = students.Where(Student.CountLessThan100());
            var bet100to200 = students.Where(Student.CountBet100to200());
            var greaterThan200 = students.Where(Student.CountGreaterThan200());

            Console.WriteLine("Students with ProblemCount less than 100 :");
            foreach (var student in lessThan100)
            {
                Console.WriteLine($"{student.Name} - {student.ProblemCount}");
            }

            Console.WriteLine("Students with ProblemCount between 100 to 200(both inclusive) :");
            foreach (var student in bet100to200)
            {
                Console.WriteLine($"{student.Name} - {student.ProblemCount}");
            }

            Console.WriteLine("Students with ProblemCount greater than 200 :");
            foreach (var student in greaterThan200)
            {
                Console.WriteLine($"{student.Name} - {student.ProblemCount}");
            }
        }
    }
   
