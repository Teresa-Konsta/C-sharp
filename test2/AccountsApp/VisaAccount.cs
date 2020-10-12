using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    class VisaAccount : Account
    {
        const double TRANSACTION_FEE = 1.5;

        public double InterestRate
        { get; set; }

        public VisaAccount(int number, double balance, string clientName, double interestRate) : 
            base(number, balance, clientName)
        {
            InterestRate = interestRate;
        }
        
        public override void Deposit(double amount)
        {
            base.Balance = ((base.Balance + amount) - TRANSACTION_FEE);
        }

        public override void Withdraw(double amount)
        {
            base.Balance = ((base.Balance - amount) - TRANSACTION_FEE);
        }
    }
}
