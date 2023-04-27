using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Soldier Number :");
        string soldierNumber = Console.ReadLine();
        Console.WriteLine("Enter Initial coins :");
        int initialCoins = Convert.ToInt32(Console.ReadLine());
        Soldier soldier = new Soldier(soldierNumber, initialCoins);

        int choice = 0;
        while (choice != 3)
        {
            Console.WriteLine("1. Collect Coins");
            Console.WriteLine("2. Attack Enemies");
            Console.WriteLine("3. End war");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Coins :");
                    int coinsToCollect = Convert.ToInt32(Console.ReadLine());
                    soldier.Playgame((s, c) => s.CollectCoins(s, c), coinsToCollect);
                    break;

                case 2:
                    Console.WriteLine("Enter Coins :");
                    int coinsToAttack = Convert.ToInt32(Console.ReadLine());
                    soldier.Playgame((s, c) => s.AttackEnemies(s, c), coinsToAttack);
                    break;

                case 3:
                     Console.WriteLine($"Balance coins for next war: {soldier.ToString()}");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
