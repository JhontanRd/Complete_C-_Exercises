using ProductCatalog.Entities;
using ProductCatalog.Servies;
using System.Globalization;

namespace ProductCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool operationIsSuccess = true;

            do
            {
                try
                {
                    Console.WriteLine("Catalog of Generics Products and Suppliers\n");

                    Console.Write("Press (1) to Products\n" +
                                  "Press (2) to Suppliers\n" +
                                  "Choose your option: ");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        Console.Write("How many products will be add: ");
                        int quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nEnter with data in this format:");
                        Console.WriteLine("Name, Price(With dot), Category\n");

                        CatalogService<Product> catalogService = new CatalogService<Product>();

                        for (int i = 1; i <= quantity; i++)
                        {
                            Console.Write("Product data: ");
                            string[] productData = Console.ReadLine().Split(',');
                            string name = productData[0];
                            double price = double.Parse(productData[1], CultureInfo.InvariantCulture);
                            string category = productData[2];
                            catalogService.AddProduct(new Product(name, price, category));
                        }
                        Console.WriteLine("\n!-------------------------------------------------------!\n");
                        catalogService.ListProducts();

                        Console.WriteLine("\nMost Expensive Product: ");
                        Product product = catalogService.GetMostExpensiveProduct();
                        Console.WriteLine(product);
                        if (operationIsSuccess == false)
                        {
                            operationIsSuccess = !operationIsSuccess;
                        }
                    }
                    else if (option == 2)
                    {
                        Console.Write("How many suppliers will be add: ");
                        int quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nEnter with data in this format:");
                        Console.WriteLine("Name,CNPJ(With dot),Products provided\n");

                        CatalogService<Supplier> catalogService = new CatalogService<Supplier>();

                        for (int i = 1; i <= quantity; i++)
                        {
                            Console.Write("Supplier data: ");
                            string[] supplierData = Console.ReadLine().Split(',');
                            string name = supplierData[0];
                            string cnpj = supplierData[1];
                            int productsProvided = int.Parse(supplierData[2]);
                            catalogService.AddSupplier(new Supplier(name, cnpj, productsProvided));
                        }
                        Console.WriteLine("\n!-------------------------------------------------------!\n");
                        catalogService.ListSuppliers(); // preciso arruma pra pular linha

                        Console.WriteLine("\nMost Expensive Product: ");
                        Supplier supplier = catalogService.GetBiggeSupplier();
                        Console.WriteLine(supplier);
                        if (operationIsSuccess == false)
                        {
                            operationIsSuccess = !operationIsSuccess;
                        }
                    }
                    
                }
                catch (FormatException ex)
                {
                    operationIsSuccess = false;
                    Console.WriteLine("\n[ERROR] Invalid format data. " + ex.Message + "\n");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                catch (OverflowException ex)
                {
                    operationIsSuccess = false;
                    Console.WriteLine("\n[ERROR] Invalid format data. " + ex.Message + "\n");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    operationIsSuccess = false;
                    Console.WriteLine("\n[ERROR] Invalid format data. " + ex.Message + "\n");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            } while (!operationIsSuccess);
        }
    }
}
