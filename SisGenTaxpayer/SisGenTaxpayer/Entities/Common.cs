using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenTaxpayer.Entities
{
    internal class Common : Collaborator
    {
        public double HealthExpenses { get; set; }

        public Common(string name, double income, double healthExpenses) : base(name, income) 
        {
            HealthExpenses = healthExpenses;
        }

        public override double CalculateTax()
        {
            if (Income < 20000.0)
            {
                return ((Income / 100) * 15) - ((HealthExpenses / 100) * 50);
            }
            else
            {
                return ((Income / 100) * 25) - ((HealthExpenses / 100) * 50);
            }
        }
    }
}
