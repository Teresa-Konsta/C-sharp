using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionDemo
{
    class SalesTransactionApp
    {
        static void Main(string[] args)
        {
            SalesTransaction testTans1 = new SalesTransaction("John", 0, 0);

            SalesTransaction testTans2 = new SalesTransaction("John", 0);

            SalesTransaction testTans3 = new SalesTransaction("John");
            testTans3.Commission = 200.00;
            Console.WriteLine($"Sales Person Name: {testTans3} – Commission: {testTans3.Commission}");
        }
    }
}
