using GameStore.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Entities
{
    public abstract class Product : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


        protected Product(int id, string name, double price, int quantity)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            { throw new DomainException("This is an invalid name."); }

            if (price == 0)
            { throw new DomainException("Not any product can be added with price equal to 0."); }

            if (quantity == 0 || quantity < 0)
            { throw new DomainException("Quantity min to add must be 1."); }

            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;  
        }

        public override string ToString()
        {
            return $"Product data-> Id: {Id}, Name: {Name}, Price: {Price.ToString("C2", new CultureInfo("en-us"))}, Quantity: {Quantity},";
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Object is not a Product");
            }
            Product otherProduct = obj as Product;
            return Name.CompareTo(otherProduct.Name);
        }
        
    }
}
