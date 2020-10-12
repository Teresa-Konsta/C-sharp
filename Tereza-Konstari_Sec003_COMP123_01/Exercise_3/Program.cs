using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Swap(ref num1, ref num2);
            Initialize(out int num3, out int num4);
            double avg = (num3 + num4) / 2;
            Console.WriteLine($"The average of two numbers is: {avg}");
        }

        private static void Swap(ref int num1, ref int num2)
        {
            Console.WriteLine($"Before swapping first number = {num1}, second number = {num2}");
            num1 = num1 + num2; // num1 = num1 * num2;
            num2 = num1 - num2; // num2 = num1 / num2;
            num1 = num1 - num2; // num1 = num1 / num2;
            Console.WriteLine($"After swapping first number = {num1}, second number = {num2}");
        }

        private static void Initialize(out int num3, out int num4)
        {
            Console.WriteLine("Enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the force number: ");
            num4 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
