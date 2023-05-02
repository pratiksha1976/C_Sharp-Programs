using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Address> addresses = new List<Address>();
        AddressBO addressBO = new AddressBO();
        using (StreamReader sr = new StreamReader("input.csv"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                addresses.Add(addressBO.CreateUser(line));
            }
        }
        addressBO.Display(addresses);
    }
}
