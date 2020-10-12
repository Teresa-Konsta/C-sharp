using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class AutomobileDemo2
    {
        static void Main(string[] args)
        {
            FinanceAutomobile finAutoObj = new FinanceAutomobile();

            for (int i = 0; i < 4; i++)
            {
                AskUser2(finAutoObj);
                if (finAutoObj.HasDuplicates())
                {
                    ExecutionEngineException();
                }
                finAutoObj.Price ++;
                finAutoObj.AmountFinanced ++;
            }
            Console.WriteLine(finAutoObj.ToString());
        }

        static public void AskUser2(FinanceAutomobile f)
        {
            Console.WriteLine("Enter automobile ID: ");
            f.IdNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maker: ");
            f.Make = Console.ReadLine();
            Console.WriteLine("Enter the year: ");
            f.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price: ");
            Console.WriteLine("The amount financed is not allowed to be greater than price.");
            do
            {
                f.Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter amount financed: ");
                f.AmountFinanced = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter interest rate in %: ");
            } while (f.AmountFinanced > f.Price);
            f.InterestRate = Convert.ToDouble(Console.ReadLine());
            f.InterestRate = f.InterestRate / 100;
        }

        private static void ExecutionEngineException()
        {
            throw new NotImplementedException();
        }
    }
}
