using System;

namespace BankAccountDetails
{
    class CurrentAccount : Account
    {
        private string _organizationName;
        private long _TIN;

        public string OrganizationName
        {
            get { return _organizationName; }
            set { _organizationName = value; }
        }

        public long TIN
        {
            get { return _TIN; }
            set { _TIN = value; }
        }

        public CurrentAccount()
        {

        }

        public CurrentAccount(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber, string _organizationName, long _TIN) : base(_holderName, _accountNumber, _IFSCCode, _contactNumber)
        {
            this._organizationName = _organizationName;
            this._TIN = _TIN;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Organization Name : " + _organizationName);
            Console.WriteLine("TIN : " + _TIN);
        }
    }
}
