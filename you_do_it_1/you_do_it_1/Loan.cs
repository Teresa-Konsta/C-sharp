using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace you_do_it_1
{
    class Loan
    {
        public const double MINIMUM_LOAN = 5000;
        
        protected double loanAmount;
        
        public int LoanNumber { get; set; }
       
        public string LastName { get; set; }
        
        public double LoanAmount
        {
            set
            {
                if (value < MINIMUM_LOAN)
                    loanAmount = MINIMUM_LOAN;
                else
                    loanAmount = value;
            }
            get
            {
                return loanAmount;
            }
        }

        public Loan(int num, string name, double amount)
        {
            LoanNumber = num;
            LastName = name;
            LoanAmount = amount;
        }
    }
}
