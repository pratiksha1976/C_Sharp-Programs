using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter event name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the cost per day");
            double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of days");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of event\n1.Exhibition\n2.Stage Event");
            int type = Convert.ToInt32(Console.ReadLine());
            double gst;
            if (type == 1){
                Console.WriteLine("Enter the number of stalls");
                int seatsStalls = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Event Details");
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Type:Exhibition");
                Console.WriteLine("Number of stalls:" + seatsStalls);
                gst = 0.05;
                double totalAmount = cost * days + cost * days * gst;
                Console.WriteLine("Total amount:{0:F}", totalAmount);
        }
            else if (type == 2){
                Console.WriteLine("Enter the number of seats");
                int seatsStalls = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Event Details");
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Type:Stage Event");
                Console.WriteLine("Number of seats:" + seatsStalls);
                gst = 0.15;
                double totalAmount = cost * days + cost * days * gst;
                Console.WriteLine("Total amount:{0:F}", totalAmount);
        }
        else{
            Console.WriteLine("Invalid input");
        }
    }
    }
