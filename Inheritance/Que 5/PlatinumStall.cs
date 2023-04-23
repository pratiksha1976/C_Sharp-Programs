using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PlatinumStall : Stall
{
	public string _coupon;
	public double _discount;
	private static double _rent;
	public PlatinumStall(){}
	public PlatinumStall(string _name, string _detail, string _owner, double _costPerDay, double _discount, string _coupon) : base(_name,_detail,_owner,_costPerDay)
	{  
		this._discount = _discount;
		this._coupon = _coupon;
	}
	public override double calculateRent(int days)
	{
		if(_coupon=="yes")
		{
			_rent=((days * _costPerDay) - ((days * _costPerDay) * _discount/100))/2;
		}
		else{
			_rent=(days * _costPerDay) - ((days * _costPerDay) * _discount/100);
		}
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
