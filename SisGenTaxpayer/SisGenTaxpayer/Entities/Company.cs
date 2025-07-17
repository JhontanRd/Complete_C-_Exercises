using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenTaxpayer.Entities
{
    internal class Company : Collaborator
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double income, int numberOfEmployees) : base(name, income)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double CalculateTax()
        {
            if (NumberOfEmployees < 10)
            {
                return ((Income / 100) * 16);
            }
            else
            {
                return ((Income / 100) * 14);
            }
        }
    }
}
