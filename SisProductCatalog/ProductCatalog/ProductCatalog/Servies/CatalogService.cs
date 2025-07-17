using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Servies
{
    class CatalogService<T> where T : IComparable
    {
        private List<T> _listOfProducts = new List<T>();
        private List<T> _listOfSuppliers = new List<T>();

        public void AddProduct(T product) 
        {
            if(product == null)
            {
                throw new ArgumentNullException("[ERROR] Is impossible add a product without data.");
            }
            else if (_listOfProducts.Contains(product))
            {
                throw new InvalidOperationException("[ERROR] This product already just there is in the list.");
            }
            _listOfProducts.Add(product);
        }

        public void AddSupplier(T supplier) 
        {
            if(supplier == null)
            {
                throw new ArgumentNullException("[ERROR] Is impossible add a supplier without data.");
            }
            else if (_listOfSuppliers.Contains(supplier))
            {
                throw new InvalidOperationException("[ERROR] This supplier already just there is in the list.");
            }
            _listOfSuppliers.Add(supplier);
        }



        public void ListProducts()
        {
            Console.WriteLine("List of products:\n");
            foreach (T item in _listOfProducts)
            {
                Console.WriteLine(item);
            }
        }

        public void ListSuppliers()
        {
            Console.WriteLine("List of suppliers:\n");
            foreach (T item in _listOfSuppliers)
            {
                Console.WriteLine(item);
            }
        }

        public T GetMostExpensiveProduct()
        {
            T item = _listOfProducts[0];
            foreach (T item2 in _listOfProducts) 
            {
                if(item2.CompareTo(item) > 0)
                {
                    item = item2;
                } 
            }
            return item;
        }

        public T GetBiggeSupplier()
        {
            T item = _listOfSuppliers[0];
            foreach (T item2 in _listOfSuppliers) 
            {
                if(item2.CompareTo(item) > 0)
                {
                    item = item2;
                } 
            }
            return item;
        }


    }
}
