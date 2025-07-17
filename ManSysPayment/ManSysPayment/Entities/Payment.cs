using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManSysPayment.Entities
{
    internal abstract class Payment
    {
        public double PaymentValue { get; set; }

        protected Payment(double payment)
        {
            PaymentValue = payment;
        }

        public abstract double CalculatePayment();
    }
}
