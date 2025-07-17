using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenTaxpayer.Entities
{
    internal abstract class Collaborator
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Collaborator(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double CalculateTax();
    }
}
