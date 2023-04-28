using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of names");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] nameList = new string[n];
        Console.WriteLine("Enter the names");

        for (int i = 0; i < n; i++)
        {
            nameList[i] = Console.ReadLine();
        }

        Console.WriteLine("Enter the min string size");
        int minLength = Convert.ToInt32(Console.ReadLine());

        string[] filteredNames = UserProgramCode.FilterArray(nameList, minLength);

        if (filteredNames.Length > 0)
        {
            Console.WriteLine("Filtered Names");
            foreach (string name in filteredNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
