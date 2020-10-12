using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scouts
{
    class GirlScout
    {
        static void Main(string[] args)
        {
            DemoScouts girlScout = new DemoScouts();
            girlScout.ScoutName = "Lisa";
            girlScout.TroopNum = 1;
            girlScout.DueOwed = 500.50;
            girlScout.Motto = "to obey the Girl Scout law";

            Console.WriteLine(girlScout.ScoutName);
            Console.WriteLine(girlScout.TroopNum);
            Console.WriteLine(girlScout.DueOwed);
            Console.WriteLine(girlScout.Motto);

            DemoScouts girlScout2 = new DemoScouts("Alice", 2, 450.60);
            Console.WriteLine(girlScout2.ScoutName);
            Console.WriteLine(girlScout2.TroopNum);
            Console.WriteLine(girlScout2.DueOwed);
            Console.WriteLine(girlScout.Motto);
        }
    }
}
