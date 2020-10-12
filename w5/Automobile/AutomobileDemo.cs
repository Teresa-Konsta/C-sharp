using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class AutomobileDemo
    {
        static void Main(string[] args)
        {
            Automobile autoInfo = new Automobile();

           for (int i = 0; i < 8; i++)
           {
                AskUser(autoInfo);
                if (autoInfo.HasDuplicates())
                {
                    ExecutionEngineException();
                }
           }
            Console.WriteLine(autoInfo.ToString()); 
        }

        static public void AskUser(Automobile a)
        {
            Console.WriteLine("Enter automobile ID: ");
            a.IdNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maker: ");
            a.Make = Console.ReadLine();
            Console.WriteLine("Enter the year: ");
            a.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price: ");
            a.Price = Convert.ToDouble(Console.ReadLine());
        }

        private static void ExecutionEngineException()
        {
            throw new NotImplementedException();
        }
    }
}
