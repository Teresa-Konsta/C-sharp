using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maths sqrtV = new Maths();

            double x;
            //double isValid;
            Console.WriteLine("Enter a number: ");
            double.TryParse(Console.ReadLine(), out x);

            double sqrtV = Maths.Sqrt(x);

        }
    }

    class Maths
    { 

        public static double Sqrt(double x)
        {
            double sqrtX = Math.Pow(x, 2);
            return sqrtX;
        }
    }
}
