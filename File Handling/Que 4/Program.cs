using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //fill code here
        List<Item> itemList = new List<Item>();
        Dictionary<string, int> itemTypeCountDict = new Dictionary<string, int>();
        List<ItemType> itemTypeList = ItemType.GetItemType();
        ItemBO itemBO = new ItemBO();

    using (StreamReader sr = new StreamReader("input.txt"))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            Item item = itemBO.CreateItem(line);
            itemList.Add(item);

            string itemType = item.ItemTypeInsance.Name;
            if (itemTypeCountDict.ContainsKey(itemType))
            {
                itemTypeCountDict[itemType]++;
            }
            else
            {
                itemTypeCountDict.Add(itemType, 1);
            }
        }
    }
    Console.WriteLine("Item type with number of items");
    Console.WriteLine("{0,-15} {1,-10}", "Item Type", "Count");
    foreach (KeyValuePair<string, int> kvp in itemBO.ItemtypeCount(itemList))
    {
        Console.WriteLine("{0,-15} {1,-10}", kvp.Key, kvp.Value);
    }
}
}
