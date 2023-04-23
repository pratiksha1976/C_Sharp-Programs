using System;
 class StageEvent : Event
    {
        private static int _gst = 15;
        private int _noOfSeats;

        public StageEvent(string name, string type, double costPerDay, int noOfDays, int noOfSeats) : base(name, type, costPerDay, noOfDays)
        {
            _noOfSeats = noOfSeats;
        }

        public double totalCost()
        {
            return (_costPerDay * _noOfDays) * (1 + (_gst / 100.0));
        }

        public override string ToString()
        {
            return base.ToString() + "\nNumber of seats:" + _noOfSeats + "\nTotal amount:" + totalCost().ToString("F2");
        }
    }
