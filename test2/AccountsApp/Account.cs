using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    abstract class Account
    {
        public int Number
        { get; set; }

        public double Balance
        { get; set; }

        public string ClientName
        { get; set; }

        public Account(int number, double balance, string clientName)
        {
            Number = number;
            Balance = balance;
            ClientName = clientName;
        }

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);
    }
}
