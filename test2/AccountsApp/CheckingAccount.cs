using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    class CheckingAccount : Account
    {
        const double TRANSACTION_FEE_DEPOSIT = 0.5;
        const double TRANSACTION_FEE_WITHDDRAW = 0.3;

        public double WithdrawLimit
        { get; set; }

        public CheckingAccount(int number, double balance, string clientName, double withdrawLimit) : 
            base(number, balance, clientName)
        {
            WithdrawLimit = withdrawLimit;
        }

        public override void Deposit(double amount)
        {
            base.Balance = ((base.Balance + amount) - TRANSACTION_FEE_DEPOSIT);
        }

        public override void Withdraw(double amount)
        {
            base.Balance = ((base.Balance - amount) - TRANSACTION_FEE_WITHDDRAW);
        }
    }
}
