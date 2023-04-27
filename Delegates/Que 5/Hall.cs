using System;
using System.Collections.Generic;

class Hall
{
    private string _hallName;
    private double _costPerDay;
    private DateTime _bookingDate;
    private string _ownerName;

    public string HallName
    {
        get { return _hallName; }
        set { _hallName = value; }
    }

    public double CostPerDay
    {
        get { return _costPerDay; }
        set { _costPerDay = value; }
    }

    public DateTime BookingDate
    {
        get { return _bookingDate; }
        set { _bookingDate = value; }
    }

    public string OwnerName
    {
        get { return _ownerName; }
        set { _ownerName = value; }
    }

    public Hall(string hallName, double costPerDay, DateTime bookingDate, string ownerName)
    {
        _hallName = hallName;
        _costPerDay = costPerDay;
        _bookingDate = bookingDate;
        _ownerName = ownerName;
    }

    public static Hall CreateHall(string hallDetail)
    {
        string[] fields = hallDetail.Split(',');
        string hallName = fields[0];
        double costPerDay = Convert.ToDouble(fields[1]);
        DateTime bookingDate = DateTime.ParseExact(fields[2], "dd-MM-yyyy", null);
        string ownerName = fields[3];
        return new Hall(hallName, costPerDay, bookingDate, ownerName);
    }

    public static List<Hall> FilterHall(List<Hall> hallList, Predicate<double> predicate)
    {
        List<Hall> filteredList = new List<Hall>();
        foreach (Hall hall in hallList)
        {
            if (predicate.Invoke(hall.CostPerDay))
            {
                filteredList.Add(hall);
            }
        }
        return filteredList;
    }

    public static void DisplayHallDetails(List<Hall> hallList)
    {
        if (hallList.Count == 0)
        {
            Console.WriteLine("No hall for that range.");
        }
        else
        {
            Console.WriteLine("{0} {1,15} {2,15} {3,15}", "Hall name", "Cost per day", "Booking date", "Owner name");
            foreach (Hall hall in hallList)
            {
                Console.WriteLine("{0}{1,16}{2,16}{3,16}", hall.HallName, hall.CostPerDay.ToString("F1") , hall.BookingDate.ToString("dd-MM-yyyy"), hall.OwnerName);
            }
        }
    }
}
