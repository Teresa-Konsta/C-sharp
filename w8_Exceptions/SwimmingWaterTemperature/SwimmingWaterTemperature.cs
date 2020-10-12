using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingWaterTemperature
{
    class SwimmingWaterTemperature
    {
        static void Main(string[] args)
        {
            int tFahrenheit;
            Console.WriteLine("Enter the current temperature: ");
            int.TryParse(Console.ReadLine(), out tFahrenheit);
            const int STOP = 999;

            while (tFahrenheit != STOP)
            {
                try
                {
                if (IndicateWaterComfort(tFahrenheit))
                    Console.WriteLine($"Water t {tFahrenheit} is comfortable for swimming");
                else
                    Console.WriteLine($"Water t {tFahrenheit} is invalid");
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    Console.WriteLine($"Error: {e.StackTrace}");
                }
                Console.WriteLine("Enter the current temperature: ");
                int.TryParse(Console.ReadLine(), out tFahrenheit);
            }
        }
            private static bool IndicateWaterComfort(int tWater)
            {
                bool tWaterComfort = false;
                const int LOW_COMFORT = 70;
                const int HIGH_COMFORT = 85;
                const int LOW_EDGE_COMFORT = 32;
                const int HIGH_EDGE_COMFORT = 212;

                if ((tWater <= LOW_EDGE_COMFORT) || (tWater >= HIGH_EDGE_COMFORT))
                    throw(new ArgumentException("Invalid t"));

                if ((tWater >= LOW_COMFORT) && (tWater <= HIGH_COMFORT))
                     tWaterComfort = true;
                else
                    tWaterComfort = false;
                return tWaterComfort;
            }
    }
}
