using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exhibition : Event
{
private int _noOfStall;
public int NoOfStall
{
    get { return _noOfStall; }
    set { _noOfStall = value; }
}

public Exhibition(string name, string type, int noOfStall) : base(name, type)
{
    _noOfStall = noOfStall;
}

public override double ProjectedRevenue()
{
    return _noOfStall * 10000;
}
}
