using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenProducts.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder msgPriceTag = new StringBuilder();
            msgPriceTag.Append($"{Name} {Price.ToString("C2", new CultureInfo("en-US"))}");
            return msgPriceTag.ToString();
        }
    }
}
