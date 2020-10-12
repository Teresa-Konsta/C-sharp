using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Automobile
    {
        private int idNum;
        private string make;
        private int year;
        private double price;

        public int IdNum
        { get; set; }

        public string Make
        { get; set; }

        public int Year
        { get; set; }

        public double Price
        { get; set; }

        public virtual string ToString()
        {
            return (GetType() + ":" + IdNum + " " + Make + " " + Year + " " + Price.ToString("C"));
        }

        internal bool HasDuplicates()
        {
            throw new ExecutionEngineException();
        }
    }
}
