using System;
using System.Linq;

public class UserProgramCode
{
    public static string[] FilterArray(string[] nameList, int minLength)
    {
        var filteredNames = nameList.Where(name => name.Length < minLength).ToArray();
        if (filteredNames.Length == 0)
        {
            Console.WriteLine($"No names present in the minimum size {minLength}");
        }
        return filteredNames;
    }
}
