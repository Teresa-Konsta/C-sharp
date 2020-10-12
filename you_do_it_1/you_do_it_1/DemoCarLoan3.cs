using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace you_do_it_1
{
    class DemoCarLoan3
    {
        static void Main(string[] args)
        {
            //Loan aLoan = new Loan();
            //aLoan.LoanNumber = 2239;
            //aLoan.LastName = "Mitchel";
            //aLoan.LoanAmount = 1000.00;
            //Console.WriteLine("Loan #{0} for {1} is for {2}",
            //    aLoan.LoanNumber, aLoan.LastName,
            //    aLoan.LoanAmount.ToString("C2"));

            //CarLoan aCarLoan = new CarLoan();
            //aCarLoan.LoanNumber = 3358;
            //aCarLoan.LastName = "Jansen";
            //aCarLoan.LoanAmount = 20000.00;
            //aCarLoan.Make = "Ford";
            //aCarLoan.Year = 2005;
            //Console.WriteLine("Loan #{0} for {1} is for {2}",
            //    aCarLoan.LoanNumber, aCarLoan.LastName,
            //    aCarLoan.LoanAmount.ToString("C2"));
            //Console.WriteLine("Loan #{0} for {1} is for a {1} {2}",
            //    aCarLoan.LoanNumber, aCarLoan.Year,
            //    aCarLoan.Make);

            Loan aLoan = new Loan(333, "Hanson", 7000);
            CarLoan aCarLoan = new CarLoan(444, "Carlisle", 30000, 2011, "BMW");
            Console.WriteLine("Loan #{0} for {1} is for {2}",
                aCarLoan.LoanNumber, aCarLoan.LastName,
                aCarLoan.LoanAmount.ToString("C2"));
            Console.WriteLine("Loan #{0} for {1} is for a {1} {2}",
                aCarLoan.LoanNumber, aCarLoan.Year,
                aCarLoan.Make);
        }
    }
}
