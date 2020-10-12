using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1Q2
{
    class TaxMath
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the tax rate: ");
            string taxRateOriginal = Console.ReadLine();
            int taxRateInt;
            double taxRateDb;

            if (int.TryParse(taxRateOriginal, out taxRateInt))
            {
                double priceFinal = CalculateTax(price, taxRateInt);
                Console.WriteLine($"The price including tax is: {priceFinal:C}");
            }
            else if(double.TryParse(taxRateOriginal, out taxRateDb))
            {
                double priceFinal = CalculateTax(price, taxRateDb);
                Console.WriteLine($"The price including tax is: {priceFinal:C}");
            }

            double price1 = CalculateTax(79.95, 0.13);
            double price2 = CalculateTax(79.95, 13);
            Console.WriteLine($"Price 1: {price1:C}");
            Console.WriteLine($"Price 2: {price2:C}");
        }
        static double CalculateTax(double price, double taxRate)
        {
            double priceWithTax = price + (price * taxRate);
            return priceWithTax;
        }

        static double CalculateTax(double price, int taxRate)
        {
            double priceWithTax = price + (price * (taxRate/100));
            return priceWithTax;
        }
    }
}
