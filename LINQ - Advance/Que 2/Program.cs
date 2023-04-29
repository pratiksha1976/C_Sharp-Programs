using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of companies");
        int numCompanies = int.Parse(Console.ReadLine());

        List<PlacedStudent> placedStudents = new List<PlacedStudent>();

        for (int i = 0; i < numCompanies; i++)
        {
            Console.WriteLine("Enter company name");
            string companyName = Console.ReadLine();

            Console.WriteLine("Enter student name");
            string studentName = Console.ReadLine();

            PlacedStudent placedStudent = new PlacedStudent(companyName, studentName);
            placedStudents.Add(placedStudent);
        }

        var groupedStudents = from student in placedStudents
                              orderby student.StudentName ascending
                              group student.StudentName by student.CompanyName;

        foreach (var group in groupedStudents)
        {
            Console.WriteLine("Company Name : {0}", group.Key);

            foreach (var studentName in group)
            {
                Console.WriteLine(studentName);
            }
        }

        Console.ReadLine();
    }
}
