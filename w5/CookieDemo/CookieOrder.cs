using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinaCookie
{
    class CookieOrder
    {
        private int orderNum;
        private string recipientName;
        private string cookieType;
        protected int dozenNum;
        protected double price;

        public int OrderNum
        { get; set; }

        public string RecipientName
        { get; set; }

        public string CookieType
        { get; set; }

        public int DozenNum
        { 
            get
            {
                return dozenNum;
            }
            set
            {
                dozenNum = value;
                SetPrice();
            }
        }

        public double Price
        { get; }

        public void SetPrice()
        {
            if (DozenNum <= 2)
            {
                price = DozenNum * 15;
            }
            else
            {
                price = 30 + ((DozenNum - 2) * 13);
            }
        }

        public virtual string ToString()
        {
            return (GetType() + "Order#: " + OrderNum + " Name: " + RecipientName + " Cookie type: " + CookieType
                + " Dozens# " + DozenNum + " Price: $" + Price);
        }
    }
}
