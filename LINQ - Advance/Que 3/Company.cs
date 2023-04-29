using System;
using System.Collections.Generic;
using System.Linq;

class Company
{
    private int _id;
    private string _name;

    public Company()
    {
    }

    public Company(int _id, string _name)
    {
        this._id = _id;
        this._name = _name;
    }

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }

}
