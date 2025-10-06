using System.Globalization;
using System.Linq;
using SysProductsPrices.Entities;

namespace SysProductsPrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise\n");

            // C:\temp\in.csv
            
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            
            
            List<Product> products = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] data = sr.ReadLine().Split(',');
                    string name = data[0];
                    double price = double.Parse(data[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
            }


            Console.WriteLine();
            double averagePrice = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

            Console.Write($"Average price: {averagePrice.ToString("C2", new CultureInfo("pr-BR"))}\n");
            List<string> productsName = products.Where(p => p.Price < averagePrice).OrderByDescending(p => p.Name).Select(p => p.Name).ToList();
            productsName.ForEach(j => Console.WriteLine(j));
        }
    }
}
