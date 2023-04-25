using System;
public class Program{
    public static void Main(){
        Console.WriteLine("Select your choice...\n1. Make My Trip\n2. Trivago\n3. Clear Trip");
        int ch = Convert.ToInt32(Console.ReadLine());
        string city;
		HotelTariff hotel;
        switch(ch)
        {
			case 1:
				//Fill your code here
				hotel = new MakeMyTrip();
				Console.WriteLine("Available Cities:");
				hotel.CityList();
				Console.WriteLine("Enter a city to view hotels:");
				city=Console.ReadLine();
				hotel.ShowTariff(city);
				break;
			case 2:
				//Fill your code here
				hotel = new Trivago();
				Console.WriteLine("Available Cities:");
				hotel.CityList();
				Console.WriteLine("Enter a city to view hotels:");
				city=Console.ReadLine();
				hotel.ShowTariff(city);
				break;
			case 3:
				//Fill your code here
				hotel = new ClearTrip();
				Console.WriteLine("Available Cities:");
				hotel.CityList();
				Console.WriteLine("Enter a city to view hotels:");
				city=Console.ReadLine();
				hotel.ShowTariff(city);
				break;
        }
    }
}
