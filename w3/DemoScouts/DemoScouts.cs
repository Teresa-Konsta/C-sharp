using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class DemoScouts
    {
        private string scoutName;
        private int troopNum;
        private double dueOwed;
        private static string motto;

        public string ScoutName
        {
            get
            {
                return scoutName;
            }
            set
            {
                scoutName = value;
            }
        }

        public int TroopNum
        {
            get
            {
                return troopNum;
            }
            set
            {
                troopNum = value;
            }
        }

        public double DueOwed
        {
            get
            {
                return dueOwed;
            }
            set
            {
                dueOwed = value;
            }
        }

        public string Motto
        {
            get
            {
                return motto;
            }
            set
            {
                motto = value;
            }
        }

        public DemoScouts()
        {
            ScoutName = "Name";
            TroopNum = 1;
            DueOwed = 500.50;
            Motto = "to obey the Girl Scout law";
        }

        public DemoScouts(string scoutName, int troopNum, double dueOwed)
        {
            ScoutName = scoutName;
            TroopNum = troopNum;
            DueOwed = dueOwed;
        }
    }
}
