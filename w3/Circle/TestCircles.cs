using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Q3
{
    class TestCircles
    {
        static void Main(string[] args)
        {
            Circle testCircle = new Circle();
            testCircle.Radius = 2;
            Console.WriteLine($"Radius: {testCircle.Radius}");
            Console.WriteLine($"Area: {testCircle.Area}");
            Console.WriteLine($"Diameter: {testCircle.Diameter}");

            testCircle.Radius = 3;
            Console.WriteLine($"Radius: {testCircle.Radius}");
            Console.WriteLine($"Area: {testCircle.Area}");
            Console.WriteLine($"Diameter: {testCircle.Diameter}");

            Circle testCircle2 = new Circle();
            Console.WriteLine($"Radius: {testCircle2.Radius}");
            Console.WriteLine($"Area: {testCircle2.Area}");
            Console.WriteLine($"Diameter: {testCircle2.Diameter}");
        }
    }
}
