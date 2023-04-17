using System;

class ThrillRide{
  static void Main(string[] args) {
    int age = int.Parse(Console.ReadLine());

    if(age < 15 || age > 60) {
      Console.WriteLine("Not Allowed");
    } else {
      Console.WriteLine("Allowed");
    }
  }
}