using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionDemo
{
    class SalesTransaction
    {
        private string name;
        private double salesAmount;
        private double commission;
        private double commissionRate;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double SalesAmount
        {
            get
            {
                return salesAmount;
            }
            set
            {
                salesAmount = value;
            }
        }

        public double Commission
        {
            get
            {
                return commission;
            }
            set
            {
                commission = value;
            }
        }

        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
        }

        public SalesTransaction(string name, double salesAmount, double commissionRate)
        {
            Name = name;
            SalesAmount = salesAmount;
            this.commissionRate = commissionRate;
            commission = salesAmount * commissionRate;
        }

        public SalesTransaction(string name, double salesAmount)
        {
            Name = name;
            SalesAmount = salesAmount;
            commissionRate = 0;
        }

        public SalesTransaction(string name)
        {
            Name = name;
            salesAmount = 0;
            commission = 0;
            commissionRate = 0;
        }

        public override string ToString()
        {
            return "Sales Person Name:" + Name + "– Commission:" + Commission;
        }

        private SalesTransaction()
        {
            commissionRate = 0.1;
        }

        static double SalesTarget;
        static public SalesTransaction
        {
           SalesTarget = 1000; //don't understand error
        }

    // Create an enumeration inside the SalesTransaction.cs file called Status with 3 possible values: “in progress”, “pending”, “paid”;
    enum Status { "in progress" "pending" "paid"};

    //Create a new property and field on the SalesTransaction class called SalesStatus of the type Status;
    //Go back to each one of the 3 constructors and set the new SalesStatus field to “in progress” in all of them;
}
}
