using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManSysOrder.Entities
{
    internal class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product(string name, int quantity, double price) 
        {
            ProductName = name;
            Quantity = quantity;
            Price = price;
        }

        public double TotalValueProduct()
        {
            return Quantity * Price;
        }
    }
}
