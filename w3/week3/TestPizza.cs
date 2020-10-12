using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPizza
{
    class TestPizza
    {
        static void Main(string[] args)
        {
            Pizza testPizza = new Pizza();
            testPizza.Toppings = "Pepperoni";
            testPizza.Diameter = 12;
            testPizza.Price = 13.99;

            Console.WriteLine($"Pizza topping: {testPizza.Toppings}");
            Console.WriteLine($"Diameter: {testPizza.Diameter}");
            Console.WriteLine($"Price: {testPizza.Price:C}");

            Pizza testPizza2 = new Pizza("Olives", 20, 30);

            Console.WriteLine($"Pizza topping: {testPizza2.Toppings}");
            Console.WriteLine($"Diameter: {testPizza2.Diameter}");
            Console.WriteLine($"Price: {testPizza2.Price:C}");
        }
    }
}
