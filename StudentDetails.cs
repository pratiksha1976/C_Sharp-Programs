using System;

class StudentDetails {
    static void Main(string[] args) {

        Console.WriteLine("Enter name :");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Roll No :");
        int rollNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Subject :");
        string subject = Console.ReadLine();

        Console.WriteLine("Enter Marks :");
        double marks = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Grade :");
        char grade = Console.ReadLine()[0];

       
        Console.WriteLine(name + " Details :");
        Console.WriteLine("Roll No : " + rollNo);
        Console.WriteLine("Subject : " + subject);
        Console.WriteLine("Marks : " + marks);
        Console.WriteLine("Grades : " + grade);
    }
}
