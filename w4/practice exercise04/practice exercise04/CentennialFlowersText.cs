using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_exercise04
{
    class CentennialFlowersText
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order();

            Console.WriteLine("Enter order details");
            Console.WriteLine("Emter order number: ");
            myOrder.OrderNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Emter customer name: ");
            myOrder.CustomerName = Console.ReadLine();
            Console.WriteLine("Emter arrangement: ");
            myOrder.Arrangement = Console.ReadLine();
            Console.WriteLine("Emter quantity: ");
            myOrder.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Emter price per unit: ");
            myOrder.UnitPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Emter ");
            Console.WriteLine("Your information has been saved in file Order.txt");

            FileStream outFile = new FileStream("Order.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(outFile);
            streamWriter.WriteLine($"Order information" +
                $"Order number: {myOrder.OrderNumber}",
                $"Customer name: {myOrder.CustomerName}", 
                $"Arrangement: {myOrder.Arrangement}", 
                $"Quantity: {myOrder.Quantity}",
                $"Price per unit: {myOrder.UnitPrice}", 
                $"Total price: {myOrder.TotalPrice}");
            streamWriter.Close();
            outFile.Close();
        }
    }
}
