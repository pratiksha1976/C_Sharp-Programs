using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter UserName");
            string username1 = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string password1 = Console.ReadLine();

            Console.WriteLine("Enter PhoneNumber");
            long phoneNumber1 = Convert.ToInt64(Console.ReadLine());

            User user1 = new User(name1, username1, password1, phoneNumber1);

            Console.WriteLine("Enter Name");
            string name2 = Console.ReadLine();

            Console.WriteLine("Enter UserName");
            string username2 = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string password2 = Console.ReadLine();

            Console.WriteLine("Enter PhoneNumber");
            long phoneNumber2 = Convert.ToInt64(Console.ReadLine());

            User user2 = new User(name2, username2, password2, phoneNumber2);

            if (user1.ComparePhoneNumber(user2))
                Console.WriteLine("Same Users");
            else
                Console.WriteLine("Different Users");
        }
    }

