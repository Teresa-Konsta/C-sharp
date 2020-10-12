using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPizza
{
    class Pizza
    {
        private string toppings; // names should be matched with a method where it's used
        private int diameter;
        private double price;

        //public string Toppings // get and set are accesory properties
        //{
        //    get
        //    {
        //        return toppings;
        //    }
        //    set
        //    {
        //        toppings = value;
        //    }
        //}

        public string Toppings // auto implemented property, but this option is limited coz we cannot write extra code for get and set
        {
            get; set;
        }

        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public Pizza() //constructor: private by default, same name as class, doesn't return anything, this constructor is better practice
        {
            Toppings = "Cheese"; // this.Toppings [...] -> but not obligatory in this case 'coz it's clear
            Diameter = 12;
            Price = 19.00;
        }

        public Pizza(string toppings, int diameter, double price)
        {
            //Toppings = toppings;
            //Diameter = diameter;
            //Price = price;

            this.toppings = toppings; // keyword "this" is a reference to the current object in the class
            this.diameter = diameter;
            this.price = price;
        }
    }
}
