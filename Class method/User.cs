using System;
   class User
    {
        private string _name;
        private string _username;
        private string _password;
        private long _phoneNumber;

        //parameterized constructor
        public User(string name, string username, string password, long phoneNumber)
        {
            _name = name;
            _username = username;
            _password = password;
            _phoneNumber = phoneNumber;
        }

        //getter and setter for _name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //getter and setter for _username
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        //getter and setter for _password
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //getter and setter for _phoneNumber
        public long PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        //method to compare phone numbers of two users
        public bool ComparePhoneNumber(User user)
        {
            if (_phoneNumber == user.PhoneNumber)
                return true;
            else
                return false;
        }
    }
