using ExercicioSecao08.Entities;
using ExercicioSecao08.Entities.Enums;
using System.Globalization;

namespace ExercicioSecao08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:\n");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            string date = Console.ReadLine();
            Client client = new Client(name, email, DateTime.Parse(date));

            Console.WriteLine("\nEnter order data:");
            Console.Write("Status (Pendeing_Payment, Processing, Shipped, Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("\nhow many items to this order? ");
            int itemsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itemsQuantity; i++)
            {
                Console.WriteLine($"\nEnter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int prodQuantity = int.Parse(Console.ReadLine());
                Product product = new Product(prodName, prodPrice);
                OrderItem orderItem = new OrderItem(prodQuantity, prodPrice, product); 
                order.Items.Add(orderItem);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
