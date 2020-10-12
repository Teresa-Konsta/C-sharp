using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePlant
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHousePlants displayPlants = new DisplayHousePlants();
            displayPlants.PlantName = "Philodendron"; // create more objects like this
            displayPlants.PlantPrice = 29.99;
            displayPlants.PlantFed = true;

            Console.WriteLine($"Plant: {displayPlants.PlantName}");
            Console.WriteLine($"Price: {displayPlants.PlantPrice}");
            Console.WriteLine($"Was plant fed within this week: {displayPlants.PlantFed}");
        }
    }
}