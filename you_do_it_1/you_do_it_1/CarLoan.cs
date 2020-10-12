using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace you_do_it_1
{
    class CarLoan : Loan
    {
        private const int EARLIEST_YEAR = 2006;
        private const int LOWEST_INVALID_NUM = 1000;
        private int year;

        public int Year
        { 
            set
            {
                if (value < EARLIEST_YEAR)
                {
                    year = value;
                    loanAmount = 0;
                }
                else
                    year = 0;
            }
            get
            {
                return year;
            }
        }

        public string Make { get; set; }

        public new int LoanNumber
        {
            get
            {
                return base.LoanNumber;
            }
            set
            {
                if (value < LOWEST_INVALID_NUM)
                    base.LoanNumber = value;
                else
                    base.LoanNumber = value % LOWEST_INVALID_NUM;
            }
        }

        public CarLoan(int num, string name, double amount,
                       int year, string make) : base(num, name, amount)
        {
            Year = year;
            Make = make;
        }
    }
}
