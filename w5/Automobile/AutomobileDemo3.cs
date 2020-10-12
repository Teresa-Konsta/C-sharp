using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class AutomobileDemo3
    {
        static void Main(string[] args)
        {
            FinanceAutomobile autoDue = new FinanceAutomobile();

            for (int i = 0; i < 4; i++)
            {
                AskUser3(autoDue);
                if (autoDue.HasDuplicates())
                {
                    ExecutionEngineException();
                }
                autoDue.Price++;
                autoDue.AmountFinanced++;
            }
            Console.WriteLine(autoDue.ToString());
            Console.WriteLine($"Due: {autoDue.ComputeDue(autoDue.AmountFinanced)}");
        }

        static public void AskUser3(FinanceAutomobile d)
        {
            Console.WriteLine("Enter automobile ID: ");
            d.IdNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maker: ");
            d.Make = Console.ReadLine();
            Console.WriteLine("Enter the year: ");
            d.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price: ");
            Console.WriteLine("The amount financed is not allowed to be greater than price.");
            do
            {
                d.Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter amount financed: ");
                d.AmountFinanced = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter interest rate in %: ");
            } while (d.AmountFinanced > d.Price);
            d.InterestRate = Convert.ToDouble(Console.ReadLine());
            d.InterestRate = d.InterestRate / 100;
        }

        private static void ExecutionEngineException()
        {
            throw new NotImplementedException();
        }
    }
}
