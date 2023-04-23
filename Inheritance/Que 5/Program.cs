using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{     
	static void Main(string[] args)
	{   
		Console.WriteLine("Enter stall name");
		string name = Console.ReadLine();
		Console.WriteLine("Enter stall detail");
		string detail = Console.ReadLine();
		Console.WriteLine("Enter stall owner name");
		string owner = Console.ReadLine();
		Console.WriteLine("Enter cost per day");
		double costPerDay = double.Parse(Console.ReadLine());
		Console.WriteLine("1.Stall 2.GoldStall 3.PlatinumStall");
		int ch = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Total Number of Days");
		 int d = int.Parse(Console.ReadLine());
		if(ch==1)
		{
			Stall ss = new Stall(name,detail,owner,costPerDay);
			ss.ToString();
			Console.WriteLine("Your Total Cost "+ss.calculateRent(d));
		}
		else if(ch==2)
		{   
			Console.WriteLine("Enter discount percentage");
			double discount = double.Parse(Console.ReadLine());
			GoldStall gs = new GoldStall(name,detail,owner,costPerDay,discount);
			gs.ToString();
			Console.WriteLine("Your Total Cost "+gs.calculateRent(d));
		}
		else if(ch==3)
		{
			Console.WriteLine("Enter discount percentage");
			double discount1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Coupon Yes/No");
			string coupon = Console.ReadLine();
			PlatinumStall ps = new PlatinumStall(name,detail,owner,costPerDay,discount1,coupon);
			ps.ToString();
			Console.WriteLine("Your Total Cost "+ps.calculateRent(d));
		}
		else{
			Console.WriteLine("Invalid choice");
		}
	}
}
