using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class FinanceAutomobile : Automobile
    {
        private double amountFinanced;
        private double interestrate;

        public double AmountFinanced
        { get; set; }

        public double InterestRate
        { get; set; }

        public double ComputeDue(double amount)
        {
            double due = 1 / 24 * amount;
            return due;
        }

        public override string ToString()
        {
            return (GetType() + ":" + IdNum + " " + Make + " " + Year + " " + Price + " " + AmountFinanced + " " + InterestRate);
        }

        internal bool HasDuplicates()
        {
            throw new ExecutionEngineException();
        }
    }
}
