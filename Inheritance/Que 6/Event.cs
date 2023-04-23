using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Event
{
    private string _name;
    private string _type;

    //fill code here
public string Name
{
    get { return _name; }
    set { _name = value; }
}

public string Type
{
    get { return _type; }
    set { _type = value; }
}

public Event(string name, string type)
{
    _name = name;
    _type = type;
}

public virtual double ProjectedRevenue()
{
    return 0.0;
}
}
