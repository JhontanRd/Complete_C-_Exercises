using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManSysPayment.Entities
{
    internal class Card : Payment
    {
        public int Fees { get; set; }
        public int Plots { get; set; }

        public Card(int plots, double payment) : base(payment) 
        {
            Plots = plots;
            Fees = 5;
        }

        public override double CalculatePayment()
        {
            return PaymentValue + ((PaymentValue / 100) * Fees);
        }
    }
}
