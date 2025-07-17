using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManSysPayment.Entities
{
    internal class Ticket : Payment
    {
        public DateTime Maturity { get; set; }
        public int Discount { get; set; }

        public Ticket(DateTime maturity, double payment) : base(payment)
        {
            Maturity = maturity;
            Discount = 10;
        }

        public override double CalculatePayment()
        {
            DateTime now = DateTime.Now;
            if(now.Date < Maturity.Date)
            {
                return PaymentValue - ((PaymentValue / 100) * Discount);
            }
            else
            {
                return PaymentValue;
            }
        }
    }
}
