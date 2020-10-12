using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Maximum(56, 89);
            Maximum(41, 36, 75);

            double resultSqr = Square(9);
            Console.WriteLine($"The square is: {resultSqr}");
            resultSqr = Square(9.9);
            Console.WriteLine($"The square is: {resultSqr}");
        }

        private static int Maximum(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"Number {num1} is greater than {num2}.");
                return num1;
            }
            else
            {
                Console.WriteLine($"Number {num1} is greater than {num2}.");
                return num2;
            }
        }

        private static int Maximum(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"Number {num1} is the greatest.");
                return num1;
            }
            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"Number {num2} is the greatest.");
                return num2;
            }
            else
            {
                Console.WriteLine($"Number {num3} is the greatest.");
                return num3;
            }
        }

        private static int Square(int valueInt)
        {
            int square = valueInt * valueInt;
            return square;
        }

        private static double Square(double valueDb)
        {
            double square = Math.Pow(valueDb, 2);
            return square;
        }
    }
}
