using System;

namespace BankAccountDetails
{
    class Account
    {
        private string _holderName;
        private long _accountNumber;
        private string _IFSCCode;
        private long _contactNumber;

        public string HolderName
        {
            get { return _holderName; }
            set { _holderName = value; }
        }

        public long AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public string IFSCCode
        {
            get { return _IFSCCode; }
            set { _IFSCCode = value; }
        }

        public long ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }

        public Account()
        {

        }

        public Account(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber)
        {
            this._holderName = _holderName;
            this._accountNumber = _accountNumber;
            this._IFSCCode = _IFSCCode;
            this._contactNumber = _contactNumber;
        }

        public virtual void Display()
        {
            Console.WriteLine("Your Contact Details");
            Console.WriteLine("HolderName : " + _holderName);
            Console.WriteLine("Account Number : " + _accountNumber);
            Console.WriteLine("IFSCCode : " + _IFSCCode);
            Console.WriteLine("ContactNumber : " + _contactNumber);
        }
    }
}
