using System;
using System.Collections.Generic;
public class Trivago:HotelTariff
{
    Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
        "Hyderabad",
        new Dictionary<string,double>
        {
            {"Park Hyatt",12000},
            {"Courtyard By Marriott",10000},
            {"Taj Krishna",14500}
        }
        },

        {
        "Mysore",
        new Dictionary<string,double>
        {
            {"Hotel Royal Orchid",20000},
            {"Hotel Kings Kourt",18000}
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
