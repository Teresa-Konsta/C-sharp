using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w6
{
    class CertifiedLetter : Letter
    {
        private int trackingNum;

        public int TrackingNum
        { 
            get
            {
                return trackingNum;
            }
           set
            {
                trackingNum = value;
            }
        }
    }
}
