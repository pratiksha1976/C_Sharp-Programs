using System;

    class Event
    {
        protected string _name;
        protected string _type;
        protected double _costPerDay;
        protected int _noOfDays;

        public Event()
        {
            _name = "";
            _type = "";
            _costPerDay = 0;
            _noOfDays = 0;
        }

        public Event(string name, string type, double costPerDay, int noOfDays)
        {
            _name = name;
            _type = type;
            _costPerDay = costPerDay;
            _noOfDays = noOfDays;
        }

        public override string ToString()
        {
            return "Name:" + _name + "\nType:" + _type;
        }
    }
