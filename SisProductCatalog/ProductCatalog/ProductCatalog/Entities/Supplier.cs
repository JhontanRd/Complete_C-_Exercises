using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Entities
{
    class Supplier : IComparable
    {
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public int ProductsProvided { get; set; }

        public Supplier(string name, string cNPJ, int productsProvided)
        {
            Name = name;
            CNPJ = cNPJ;
            ProductsProvided = productsProvided;
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Supplier)) 
            {
                throw new ArgumentException("[ERROR] This is not a valid supplier.");
            }
            Supplier other = obj as Supplier;
            return ProductsProvided.CompareTo(other.ProductsProvided);
        }

        public override string ToString() 
        {
            return $"-> Name: {Name}, CNPJ: {CNPJ}, Products provided: {ProductsProvided}";
        }
    }
}
