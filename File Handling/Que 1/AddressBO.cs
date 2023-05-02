using System.Collections.Generic;
using System.IO;

public class AddressBO
{
    public Address CreateUser(string value)
    {
        string[] addressDetails = value.Split(',');
        return new Address(addressDetails[0], addressDetails[1], addressDetails[2], addressDetails[3], int.Parse(addressDetails[4]));
    }

    public void Display(List<Address> list)
    {
        System.Console.WriteLine("Address details");
        System.Console.WriteLine("{0,-15} {1,-25} {2,-15} {3,-15} {4,-15}", "Address line 1", "Address line 2", "City", "State", "Pincode");
        foreach (Address address in list)
        {
            System.Console.WriteLine("{0,-15} {1,-25} {2,-15} {3,-15} {4,-15}", address.AddressLine1, address.AddressLine2, address.City, address.State, address.Pincode);
        }
    }
}
