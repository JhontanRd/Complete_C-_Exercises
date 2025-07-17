using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenParking.Entities
{
    internal class Parking
    {
        public List<Carr> Carrs { get; set; } = new List<Carr>();

        public Parking() { }

        public void AddCarr(Carr carr)
        {
            Carrs.Add(carr);
        }

        public void RemoveCarr(Carr carr)
        {
            Carrs.Remove(carr);
        }

        public double CalculateTotal()
        {
            double tot = 0f;
            foreach (Carr carr in Carrs)
            {
                tot += carr.Calculatevalue();
            }
            return tot;
        }
    }
}
