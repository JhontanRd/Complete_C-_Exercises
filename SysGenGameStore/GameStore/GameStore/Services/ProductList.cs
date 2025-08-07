using GameStore.Entities;
using System.Globalization;
using System.Xml.Linq;

namespace GameStore.Services
{
    public class ProductList<T> where T : Product
    {
        private List<T> _list = new List<T>();


        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Remove(string name)
        {
            if (!(string.IsNullOrEmpty(name)))
            {
                foreach (Product product in _list)
                {
                    if (name == product.Name)
                    {
                        _list.Remove((T)product);
                        Console.WriteLine("-> Product removed.");
                        break;
                    }
                    else if (product == _list.Last())
                    {
                        Console.WriteLine($"-> Product with name {name} not found.");
                    }
                }
            }
            else
            {
                Console.WriteLine("-> Product name cannot be null or empty.");

            }
        }

        public void Clear()
        {
            _list.Clear();
        }

        public int Count()
        {
            return _list.Count;
        }

        public void Sort()
        {
            _list.Sort();
        }

        public void Sort(IComparer<T> comparer)
        {
            _list.Sort(comparer);
        }

        public void Show()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Search(string name)
        {
            if (!(string.IsNullOrEmpty(name)))
            {
                foreach (Product product in _list)
                {
                    if (name == product.Name)
                    {
                        Console.WriteLine(product);
                        break;
                    }
                    else if (product == _list.Last())
                    {
                        Console.WriteLine($"-> Product with name {name} not found.");
                    }
                }
            }
            else
            {
                Console.WriteLine("-> Product name cannot be null or empty.");
                return;
            }

        }

        public void Search(double price)
        {
            if (price > 0)
            {
                foreach (Product product in _list)
                {
                    if (price == product.Price)
                    {
                        Console.WriteLine(product);
                        break;
                    }
                    else if (product == _list.Last())
                    {
                        Console.WriteLine($"-> There is not found any product with a price of: {price.ToString("C2", new CultureInfo("en-us"))}.");
                    }
                }
            }
            else
            {
                Console.WriteLine($"-> There is not found any product with a price of: {price.ToString("C2", new CultureInfo("en-us"))}.");
                return;
            }

        }

    }
}
