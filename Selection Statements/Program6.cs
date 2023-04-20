using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine("Enter the marks");
    int marks = Convert.ToInt32(Console.ReadLine());

    if (marks >= 0 && marks <= 100) {
      if (marks == 100) {
        Console.WriteLine("The student obtained a S grade");
      }
      else if (marks >= 90 && marks < 100) {
        Console.WriteLine("The student obtained a A grade");
      }
      else if (marks >= 80 && marks < 90) {
        Console.WriteLine("The student obtained a B grade");
      }
      else if (marks >= 70 && marks < 80) {
        Console.WriteLine("The student obtained a C grade");
      }
      else if (marks >= 60 && marks < 70) {
        Console.WriteLine("The student obtained a D grade");
      }
      else if (marks >= 50 && marks < 60) {
        Console.WriteLine("The student obtained a E grade");
      }
      else {
        Console.WriteLine("The student obtained a F grade");
      }
    }
    else {
      Console.WriteLine("Invalid Input");
    }
  }
}