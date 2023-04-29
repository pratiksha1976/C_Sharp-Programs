using System;
using System.Collections.Generic;
using System.Text;

class Customer
{
    private int _id;
    private string _firstName;
    private string _lastName;

    public Customer(int _id, string _firstName, string _lastName)
    {
        this._id = _id;
        this._firstName = _firstName;
        this._lastName = _lastName;
    }

    public int Id { get => _id; set => _id = value; }
    public string FirstName { get => _firstName; set => _firstName = value; }
    public string LastName { get => _lastName; set => _lastName = value; }
}
