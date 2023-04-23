using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Stall
{
	protected string _name;
	protected string _detail;
	protected string _owner;
	protected double _costPerDay;
	private static double _rent;
	public Stall(){ }
	public Stall(string _name, string _detail, string _owner,double _costPerDay)
	{
		this._name = _name;
		this._detail = _detail;
		this._owner = _owner;
		this._costPerDay = _costPerDay;
	}
	public virtual double calculateRent(int days)
	{
		_rent=days * _costPerDay;
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
