using SisGenProducts.Entities;
using System.Globalization;

namespace SisGenProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> listOfProducts = new List<Product>();

            Console.Write("Enter the number of products: ");
            int productsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= productsQuantity; i++) 
            {
                Console.WriteLine($"\nProduct #{i} data:");
                Console.Write("Common, used, imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == 'U')
                {
                    Console.Write("Manufactured date (DD/MM/YYYY): ");
                    string date = Console.ReadLine();
                    string dia = date.Substring(0, 2);
                    string mes = date.Substring(3, 2);
                    string ano = date.Substring(6, 4);
                    DateTime manufacturedDate = DateTime.Parse($"{dia}/{mes}/{ano}");
                    UsedProduct product = new UsedProduct(productName, productPrice, manufacturedDate);
                    listOfProducts.Add(product);
                }
                else if(productType == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct product = new ImportedProduct(productName, productPrice, customFee);
                    listOfProducts.Add(product);
                }
                else 
                { 
                    Product product = new Product(productName, productPrice);
                    listOfProducts.Add(product);
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in listOfProducts)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
