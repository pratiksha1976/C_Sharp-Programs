using System;
using System.Collections.Generic;

public class ClearTrip:HotelTariff
{
    Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
        "Chennai",
        new Dictionary<string,double>
        {
            {"Leela Palace",25000},
            {"Hilton",20000},
            {"WoodLands",18000}
        }
        },

        {
        "Bangalore",
        new Dictionary<string,double>
        {
            {"Adarsh Hamilton",12000},
            {"Wonderla Resort",15000},
            {"Olde Bangalore Resort",20000}
        }
        }
    };
	//Fill your code here

	public void CityList()
    {
        foreach (string city in HotelList.Keys)
        {
            Console.WriteLine(city);
        }
    }
    
    public void ShowTariff(string city)
    {
        if (HotelList.ContainsKey(city))
        {
            Console.WriteLine("Hotel List with Tariff:");
            foreach (KeyValuePair<string, double> hotel in HotelList[city])
            {
                Console.WriteLine(hotel.Key + " - Rs." + hotel.Value);
            }
        }
        else
        {
            Console.WriteLine("Selected City not found...");
        }
    }
    
}
