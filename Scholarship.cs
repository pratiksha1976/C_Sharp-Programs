using System;

class Program {
    static void Main(string[] args) {
        int[] marks = new int[5];

        // Input marks
        Console.WriteLine("Enter the subject 1 mark");
        marks[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the subject 2 mark");
        marks[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the subject 3 mark");
        marks[2] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the subject 4 mark");
        marks[3] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the subject 5 mark");
        marks[4] = Convert.ToInt32(Console.ReadLine());

        
        bool isEligible = true;
        int fullScoreCount = 0;
        int totalScore = 0;
        foreach (int mark in marks) {
            if (mark <= 2 || mark>5) {
                isEligible = false;
                break;
            }
            if (mark == 5) {
                fullScoreCount++;
            }
            totalScore += mark;
        }
        if (!isEligible || fullScoreCount == 0 || (totalScore / 5) < 4) {
            Console.WriteLine("No");
        } else {
            Console.WriteLine("Yes");
        }
    }
}
