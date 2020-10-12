using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    class FramedPhoto : Photo
    {
        private string material;
        private string style;

        public string Material
        { get; set; }

        public string Style
        { get; set; }

        public override string ToString()
        {
            return (GetType() + "Width: " + PhotoWidth + "Height: " + PhotoHeight + 
                "Price: " + (Price + 25) + "Material: " + Material + "Style: " + Style);
        }
    }
}
