using System;
 class Exhibition : Event
    {
        private static int _gst = 5;
        private int _noOfStalls;

        public Exhibition(string name, string type, double costPerDay, int noOfDays, int noOfStalls) : base(name, type, costPerDay, noOfDays)
        {
            _noOfStalls = noOfStalls;
        }

        public double totalCost()
        {
            return (_costPerDay * _noOfDays) * (1 + (_gst / 100.0));
        }

        public override string ToString()
        {
            return base.ToString() + "\nNumber of stalls:" + _noOfStalls + "\nTotal amount:" + totalCost().ToString("F2");
        }
    }
