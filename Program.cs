using System;

class Program {
    static void Main(string[] args) {
        // Taking input for initial amount
        Console.WriteLine("Enter the amount you are entering the game with:");
        float amount = float.Parse(Console.ReadLine());

        // Checking if amount is greater than or equal to 1000
        if (amount < 1000) {
            Console.WriteLine("You cannot enter the game with this money");
            return;
        }

        char playAgain;
        do {
            // Taking input for dice value
            int diceValue;
            do {
                Console.WriteLine("Value of dice");
                if (!int.TryParse(Console.ReadLine(), out diceValue) || diceValue < 1 || diceValue > 6) {
                    Console.WriteLine("Invalid value");
                    Console.WriteLine("Please enter a valid value");
                }
                 } while (diceValue < 1 || diceValue > 6);

            // Checking if dice value is 1
            if (diceValue == 1) {
                amount /= 2;
                break;
            }

            // Calculating new amount
            amount += diceValue * 100;

            // Asking user if they want to play again
            Console.WriteLine("Do you continue[y or n]?");
            playAgain = char.Parse(Console.ReadLine());
        } while (playAgain == 'y');

        // Printing final amount
        Console.WriteLine("Amount received while leaving the game " + amount);
    }
}
   
