using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProductCatalog.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Product(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Product)) 
            {
                throw new ArgumentException("[ERROR] this is not a Product.");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"-> Name: {Name}, Price: {Price.ToString("C2", new CultureInfo("pt-br"))}, Category: {Category}";
        }
    }
}
