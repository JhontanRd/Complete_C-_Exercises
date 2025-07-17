using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenProducts.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            StringBuilder msgPriceTag = new StringBuilder();
            msgPriceTag.Append($"{Name} ");
            msgPriceTag.Append($"(used) {Price.ToString("C2", new CultureInfo("en-US"))} ");
            msgPriceTag.Append($"(Manufactured date: {ManufacturedDate.ToShortDateString()})");
            return msgPriceTag.ToString();
        }
    }
}
