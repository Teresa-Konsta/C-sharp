using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    class MattePhoto : Photo
    {
        private string color;

        public string Color
        { get; set; }

        public override string ToString()
        {
            return (GetType() + "Width: " + PhotoWidth + "Height: " + PhotoHeight + "Price: " + (Price + 10) + "Color: " + Color);
        }
    }
}
