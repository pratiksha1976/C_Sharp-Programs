using System;
using System.Collections.Generic;
using System.Text;

class Course
{
    private string _id;
    private string _name;
    private string _category;
    private int _price;

    public Course()
    {
    }

    public Course(string _id, string _name, string _category, int _price)
    {
        this._id = _id;
        this._name = _name;
        this._category = _category;
        this._price = _price;
    }

    public string Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public string Category { get => _category; set => _category = value; }
    public int Price { get => _price; set => _price = value; }
}
