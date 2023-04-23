using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StageEvent : Event
{
private int _noOfShows;
private int _noOfSeats;

public int NoOfShows
{
    get { return _noOfShows; }
    set { _noOfShows = value; }
}

public int NoOfSeats
{
    get { return _noOfSeats; }
    set { _noOfSeats = value; }
}

public StageEvent(string name, string type, int noOfSeats, int noOfShows) : base(name, type)
{
    _noOfSeats = noOfSeats;
    _noOfShows = noOfShows;
}

public override double ProjectedRevenue()
{
    return _noOfSeats * _noOfShows * 50;
}
}
