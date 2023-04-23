using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GoldStall : Stall
{
	public double _discount;
	private static double _rent;
	public GoldStall(){ }
	public GoldStall(string _name, string _detail, string _owner, double _costPerDay, double _discount) : base(_name,_detail,_owner,_costPerDay)
	{
		this._discount = _discount;
	}
    public override double calculateRent(int days)
	{
		_rent=(days * _costPerDay) - ((days * _costPerDay )* _discount/100);
		return _rent;
	}
	public override string ToString()
	{
		Console.WriteLine("Name : "+_name);
	   Console.WriteLine("Detail : "+_detail);
	   Console.WriteLine("Owner : "+_owner);
	   Console.WriteLine("Cost Per Day : "+_costPerDay);
		return "";
	}
}
