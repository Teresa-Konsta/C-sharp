using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w6
{
    class Letter
    {
        private string clientName;
        private string dateMailed;

        public string ClientName
        { get; set; }

        public string DateMailed
        { get; set; }

        public new string ToString()
        {
            return (GetType() + ":" + ClientName + " " + DateMailed);
        }
    }
}
