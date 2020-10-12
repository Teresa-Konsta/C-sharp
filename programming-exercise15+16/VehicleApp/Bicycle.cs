using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    public class Bicycle : Vehicle
    {
        const double INTEREST = 0.1;

        public string Terrain
        { get; set; }

        public int TireSize
        { get; set; }

        public Bicycle(string name, string brand, double price, int warranty, string store, int tireSize, string terrain) :
            base(name, brand, price, warranty, store)
        {
            Terrain = terrain;
            TireSize = tireSize;
        }

        public override string Operate()
        {
            return "You need to pedal!";
        }

       public override double CalculateInterest()
        {
            double interest = (base.Price * INTEREST);
            return interest;
        }
    }
}
