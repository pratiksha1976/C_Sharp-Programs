using System;
using System.Collections.Generic;
using System.IO;

public class ContactBO
{
    public void AddData(List<Contact> list)
    {
        List<Contact> uniqueContacts = new List<Contact>();
        foreach (Contact contact in list)
        {
            if (!uniqueContacts.Contains(contact))
            {
                uniqueContacts.Add(contact);
            }
        }

        using (StreamWriter writer = new StreamWriter("output.csv"))
        {
            foreach (Contact contact in uniqueContacts)
            {
                writer.WriteLine($"{contact.Name},{contact.Mobile},{contact.AltMobile},{contact.Address},{contact.Email}");
            }
        }

        Console.WriteLine("Contact Details Added");
    }
}
