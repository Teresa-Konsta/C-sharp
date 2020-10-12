using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinaCookie
{
    class SpecialCookieOrder : CookieOrder
    {
        private string specialReason;
        protected double priceSpecial;

        public string SpecialReason
        { 
           get
            {
                return specialReason;
            }
          set
            {
                specialReason = value;
            }
        }

        
        public double SpecialPrice
        {
            get
            {
                return Price;
            }
            set
            {
                priceSpecial = value;
                if (Price <= 40)
                {
                    priceSpecial = Price + 10;
                }
                else
                {
                    priceSpecial = Price + 8;
                }
            }
        }

        public override string ToString()
        {
            return (GetType() + "Order#: " + OrderNum + " Name: " + RecipientName + " Cookie type: " + CookieType
                + " Dozens# " + DozenNum + " Special: " + SpecialReason + " Price: $" + SpecialPrice);
        }
    }
}
