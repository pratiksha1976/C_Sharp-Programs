using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // read number of companies and their details
        Console.WriteLine("Enter number of companies");
        int m = int.Parse(Console.ReadLine());
        List<Company> companies = new List<Company>();
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Enter company {i+1} details");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            companies.Add(new Company(id, name));
        }

        // read number of students and their details
        Console.WriteLine("Enter number of students");
        int n = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter student {i+1} details");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int companyId = int.Parse(Console.ReadLine());
            students.Add(new Student(id, name, companyId));
        }

        // query to retrieve company name and students who got placed in that company
        var query = from c in companies
                    join s in students on c.Id equals s.CompanyId
                    group s by c.Name into g
                    select new { CompanyName = g.Key, Students = g.Select(s => s.Name) };

        // display results
        foreach (var result in query)
        {
            Console.WriteLine(result.CompanyName);
            foreach (string student in result.Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
