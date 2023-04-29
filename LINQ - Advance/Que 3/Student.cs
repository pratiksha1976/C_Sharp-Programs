using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    private int _id;
    private string _name;
    private int _companyId;

    public Student()
    {
    }

    public Student(int _id, string _name, int _companyId)
    {
        this._id = _id;
        this._name = _name;
        this._companyId = _companyId;
    }

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public int CompanyId { get => _companyId; set => _companyId = value; }
}
