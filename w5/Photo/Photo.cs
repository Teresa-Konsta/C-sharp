using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    class Photo
    {
        private int photoWidth;
        private int photoHeight;
        protected double price;

        public int PhotoWidth
        { get
            {
                return photoWidth;
            }
           set
            {
                photoWidth = value;
                SetPrice();
            }
        }

        public int PhotoHeight
        { 
            get
            {
                return photoHeight;
            }
            set
            {
                photoHeight = value;
                SetPrice();
            }
        }

        public double Price
        { 
            get
            {
                return price;
            }
        }

        public void SetPrice()
        {
            if (PhotoWidth == 8 & PhotoHeight == 10)
            {
                price = 3.99;
            }
            if (PhotoWidth == 10 & PhotoHeight == 12)
            {
                price = 5.99;
            }
            else
            {
                price = 9.99;
            }
        }

        public new string ToString()
        {
            return (GetType() + "Width: " + PhotoWidth + "Height: " + PhotoHeight + "Price: " + Price);
        }
    }
}
