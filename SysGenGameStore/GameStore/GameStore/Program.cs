using GameStore.Entities;
using GameStore.Entities.Enums;
using GameStore.Entities.Exceptions;
using GameStore.Services;
using System.Globalization;

namespace GameStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductList<Product> productList = new ProductList<Product>();
            bool repeat = false;

            do
            {
                try
                {
                    Console.WriteLine("__Game Store Manager__\n");

                    Console.Write("-> Press (1) to add a new product\n" +
                                  "-> Press (2) to see all products\n" +
                                  "-> Press (3) to search for a product\n" +
                                  "-> Press (4) to remove product\n" +
                                  "-> Press (5) to exit\n" +
                                  "-> Choose your option: ");
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Write("\n-> How many products will be add: ");
                            int numberOfProducts = int.Parse(Console.ReadLine());

                            for (int i = 1; i <= numberOfProducts; i++)
                            {
                                Console.WriteLine($"\n-> {i}º product:");
                                Console.Write("-> Product name: ");
                                string name = Console.ReadLine();
                                Console.Write("-> Price: ");
                                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                Console.Write("-> Quantity: ");
                                int quantity = int.Parse(Console.ReadLine());
                                Console.Write("\n-> Press (1) to add a new Accessory\n" +
                                              "-> Press (2) to add a new Computer\n" +
                                              "-> Press (3) to add a new Digital Game\n" +
                                              "-> Press (4) to add a new Game Console\n" +
                                              "-> Choose your option: ");
                                int productType = int.Parse(Console.ReadLine());

                                if (productType == 1)
                                {
                                    productList = AddAccessory(name, price, quantity, productList);
                                }
                                else if (productType == 2)
                                {
                                    productList = AddComputer(name, price, quantity, productList);
                                }
                                else if (productType == 3)
                                {
                                    productList = AddDigitalGame(name, price, quantity, productList);
                                }
                                else if (productType == 4)
                                {
                                    productList = AddGameConsole(name, price, quantity, productList);
                                }
                                else
                                {
                                    Console.WriteLine("-> [ERROR] Invalid option! Try again.");
                                }
                                Console.Clear();
                            }
                            Console.WriteLine("-> Success! Press any butor to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            repeat = true;
                            break;

                        case 2:
                            Console.Write("\n-> Press (1) to list by name\n" +
                                            "-> Press (2) to list by price (ASCENDING)\n" +
                                            "-> Press (3) to list by price (DESCENDING)\n" +
                                            "-> Press (4) to list type os product\n" +
                                            "-> Press (5) to back\n" +
                                            "-> Choose your option: ");
                            int listOption = int.Parse(Console.ReadLine());

                            if (listOption == 1)
                            {
                                productList.Sort();
                                Console.WriteLine("-> Products sorted by name:\n");
                                productList.Show();
                            }
                            else if (listOption == 2)
                            {
                                productList.Sort(new SortByAscPrice());
                                Console.WriteLine("-> Products sorted by price (ASCENDING):\n");
                                productList.Show();
                            }
                            else if (listOption == 3)
                            {
                                productList.Sort(new SortByDescPrice());
                                Console.WriteLine("-> Products sorted by price (DESCENDING):\n");
                                productList.Show();
                            }
                            else if (listOption == 4)
                            {
                                productList.Sort(new SortByType());
                                Console.WriteLine("-> Products sorted by type:\n");
                                productList.Show();
                            }
                            else if (listOption == 5)
                            {
                                repeat = true;
                            }
                            else
                            {
                                Console.WriteLine("-> [ERROR] Invalid option! Please try again.");
                                repeat = true;
                                break;
                            }
                            Console.WriteLine("-> Success! Press any butor to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            repeat = true;
                            break;

                        case 3:
                            Console.Write("\n-> Press (1) to search by name\n" +
                                            "-> Press (2) to search by price\n" +
                                            "-> Choose your option: ");
                            int searchOption = int.Parse(Console.ReadLine());

                            if (searchOption == 1)
                            {
                                Console.Write("\n-> Name: ");
                                string name = Console.ReadLine();
                                Console.WriteLine();
                                productList.Search(name);
                            }
                            else if (searchOption == 2)
                            {
                                Console.Write("\n-> Price: ");
                                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                Console.WriteLine();
                                productList.Search(price);
                            }
                            else
                            {
                                Console.WriteLine("\n-> [ERROR] Invalid option! Try again");
                            }
                            Console.WriteLine("-> Press any button to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            repeat = true;
                            break;

                        case 4:
                            Console.Write("\n-> Enter with name to remove a product: ");
                            string nameToRemove = Console.ReadLine();
                            Console.WriteLine();
                            productList.Remove(nameToRemove);
                            Console.WriteLine("-> Press any button to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            repeat = true;
                            break;

                        case 5:
                            Console.WriteLine("\n-> Exiting the program...");
                            repeat = false;
                            break;

                        default:
                            Console.WriteLine("\n-> Invalid option, please try again.");
                            Console.WriteLine("-> Press any button to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            repeat = true;
                            break;
                    }
                }
                catch (DomainException ex)
                {
                    Console.WriteLine("\n[ERROR] Invalid operation! " + ex.Message);
                }
                catch (FormatException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} {ex.GetType()}");
                }

                // final do bloca try

            } while (repeat);
            // final do while


        }

        // AUXILIAR METHODS

        private static ProductList<Product> AddAccessory(string name, double price, int quantity, ProductList<Product> productList)
        {
            Console.WriteLine("\n-> All accessory types:\n");
            ShowEnumerable<AccessoryType>();

            Console.Write("\n-> Accessory type: ");
            AccessoryType accessoryType = (AccessoryType)int.Parse(Console.ReadLine());
            Console.Write("-> Compatibility: ");
            string compatibility = Console.ReadLine();

            productList.Add(new Accessory(productList.Count() + 1, name, price, quantity, accessoryType, compatibility));
            Console.WriteLine("\n-> New product add!");
            Thread.Sleep(1000);
            return productList;
        }

        private static ProductList<Product> AddComputer(string name, double price, int quantity, ProductList<Product> productList)
        {
            Console.WriteLine("\n-> All Brands:\n");
            ShowEnumerable<Brand>();

            Console.Write("\n-> Brand: ");
            Brand brand = (Brand)int.Parse(Console.ReadLine());
            Console.Write("-> Storage (GB): ");
            int storage = int.Parse(Console.ReadLine());
            Console.Write("-> Memory (GB): ");
            int memory = int.Parse(Console.ReadLine());
            Console.Write("-> Processor: ");
            string processor = Console.ReadLine();

            productList.Add(new Computer(productList.Count() + 1, name, price, quantity, brand, storage, memory, processor));
            Console.WriteLine("\n-> New product add!");
            Thread.Sleep(1000);
            return productList;
        }

        private static ProductList<Product> AddDigitalGame(string name, double price, int quantity, ProductList<Product> productList)
        {
            Console.WriteLine("\n-> All platforms:\n");
            ShowEnumerable<Platform>();

            Console.Write("\n-> Platform: ");
            Platform platform = (Platform)int.Parse(Console.ReadLine());
            Console.WriteLine("-> All game genres:\n");
            ShowEnumerable<GameGenre>();

            Console.Write("\n-> Game Genre: ");
            GameGenre gameGenre = (GameGenre)int.Parse(Console.ReadLine());
            Console.Write("-> Age Rating: ");
            int ageRating = int.Parse(Console.ReadLine());
            Console.Write("-> Size (GB): ");
            int size = int.Parse(Console.ReadLine());

            productList.Add(new DigitalGame(productList.Count() + 1, name, price, quantity, platform, gameGenre, ageRating, size));
            Console.WriteLine("\n-> New product add!");
            Thread.Sleep(1000);
            return productList;
        }

        private static ProductList<Product> AddGameConsole(string name, double price, int quantity, ProductList<Product> productList)
        {
            Console.Write("\n-> Manufacturer: ");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("\n-> All platforms:\n");
            ShowEnumerable<Platform>();

            Console.Write("\n-> Platform: ");
            Platform platform = (Platform)int.Parse(Console.ReadLine());
            Console.Write("-> Model: ");
            string model = Console.ReadLine();

            productList.Add(new GameConsole(productList.Count() + 1, name, price, quantity, manufacturer, platform, model));
            Console.WriteLine("\n-> New product add!");
            Thread.Sleep(1000);
            return productList;
        }

        public static void ShowEnumerable<T>() where T : Enum
        {
            foreach (T type in Enum.GetValues(typeof(T)))
            {
                Console.WriteLine($"-> Press ({Convert.ToInt32(type)}) to {type.ToString()}");
            }
        }
    }
}
