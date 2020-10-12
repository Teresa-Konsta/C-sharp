using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Q3
{
    class Circle
    {
        private double radius;
        private double area;
        private double diameter;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = Math.PI * Math.Pow(2, radius);
            }
        }

        public double Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = 2 * radius;
            }
        }

        public Circle()
        {
            Radius = 1;
        }
    }
}
