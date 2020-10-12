using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_exercise04
{
    class Order
    {
        private int orderNumber;
        private string customerName;
        private string arrangement;
        private int quantity;
        private double unitPrice;
        private double totalPrice;

        public int OrderNumber
        {
            get
            {
                return orderNumber;
            }
            set
            {
              orderNumber  = value;
            }
        }

        public string CustomerName
        {
            get
        {
                return customerName;
            }
        set
            {
              customerName  = value;
            }
        }

public string Arrangement
        {
            get
        {
                return arrangement;
            }
        set
            {
              arrangement  = value;
            }
        }

    public int Quantity
        {
            get
        {
                return quantity;
            }
        set
            {
              quantity  = value;
            }
        }

    public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
        set
            {
             unitPrice = value;
            }
        }

    public double TotalPrice
        {
            get
            {
                return totalPrice;
            }
        }

        public Order()
        {
            totalPrice = quantity * unitPrice;
        }
    }
}
