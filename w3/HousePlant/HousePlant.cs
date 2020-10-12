using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePlant
{
    class DisplayHousePlants
    {
        private string plantName;
        private double plantPrice;
        private bool plantFed;

        public string PlantName
        {
            get
            {
                return plantName;
            }
            set
            {
                plantName = value;
            }
        }

        public double PlantPrice
        {
            get
            {
                return plantPrice;
            }
            set
            {
                plantPrice = value;
            }
        }

            public bool PlantFed
        {
            get
            {
                return plantFed;
            }
            set
            {
                plantFed = value;
            }
        }
    }
}
