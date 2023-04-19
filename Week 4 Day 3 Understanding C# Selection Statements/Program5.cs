// EarthQuake Intensity Decision

// Mr. Ram is a very rich businessman and he  lost his family in the Gujarat Earthquake. He lost interest in his business after the tragic incident and he decided to serve the society. He started an NGO named after his only son Santosh to help the earth-quake victims. Santosh Helpline will provide a compensation to all earth quake survivors.

// The compensation amount given to the survivors is not fixed and it depends on the intensity of the earthquake.

// The expression Richter magnitude scale refers to a number of ways to assign a single number to quantify the energy contained in an earthquake.

// Earthquake Magnitude Scale

// Magnitude

// Type

// 2.4 or less

// Micro

// 2.5 to 5.4

// Light

// 5.5 to 6.0

// Moderate

// 6.1 to 6.9

// Strong

// 7.0 to 7.9

// Major

// 8.0 or greater

// Great

// Please help Ram to decide the intensity of the earthquake.

 

// Input Format:

// Input consists of a single floating point number which corresponds to the earthquake's ritcher magnitude scale.

// Ouput Format:

// Output consists of the string “Micro” or “Light” or “Moderate” or “Strong” or “Major” or Great”

// Refer sample input and output for further formatting specifications.

// [All text in bold corresponds to input and the rest corresponds to output]


// Sample Input and Output 1:

// Richter Magnitude:

// 5.7

// Moderate


using System;

class Program{
  public static void Main (string[] args) {
    
    Console.WriteLine("Richter Magnitude:");
    float magnitude = float.Parse(Console.ReadLine());

    
    string intensity = "";
    if (magnitude <= 2.4) {
      intensity = "Micro";
    }
    else if (magnitude <= 5.4) {
      intensity = "Light";
    }
    else if (magnitude <= 6.0) {
      intensity = "Moderate";
    }
    else if (magnitude <= 6.9) {
      intensity = "Strong";
    }
    else if (magnitude <= 7.9) {
      intensity = "Major";
    }
    else {
      intensity = "Great";
    }

    
    Console.WriteLine(intensity);
  }
}