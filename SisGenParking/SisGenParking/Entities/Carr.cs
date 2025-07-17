using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisGenParking.Entities.Enums;

namespace SisGenParking.Entities
{
    internal class Carr
    {
        public Category CategoryCarr { get; set; }
        public DateTime HoursTime { get; set; }

        public Carr() { }

        public Carr(DateTime hoursTime, Category category) 
        {
            HoursTime = hoursTime;
            CategoryCarr = category;
        }

        public double Calculatevalue()
        {
            return HoursTime.Hour * Convert.ToInt32(CategoryCarr);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Car category: ");
            sb.Append($"{CategoryCarr.ToString()} ");
            sb.Append("Rented at: ");
            sb.AppendLine(HoursTime.ToShortTimeString());
            return sb.ToString();
        }
    }
}
