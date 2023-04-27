using System;
using System.Collections.Generic;

    class Account
    {
        private string aNumber;
        private double premium;
        private int discountPercent;

        public Account(string aNumber, double premium, int discountPercent)
        {
            this.aNumber = aNumber;
            this.premium = premium;
            this.discountPercent = discountPercent;
        }

        public string ANumber { get { return aNumber; } }
        public double Premium { get { return premium; } }
        public int DiscountPercent { get { return discountPercent; } }

        //Lambda expression to calculate actual price
        public Func<double, int, double> ActualPrice = (prem, discPerc) => prem - (prem * discPerc / 100.0);

        public override string ToString()
        {
            double actualPrice = ActualPrice(premium, discountPercent);
            return $"Account : {aNumber}\nPremium : Rs.{premium:F1}\nDiscount :{discountPercent}%\nAmount to be paid : Rs.{actualPrice:F1}";
        }
    }
