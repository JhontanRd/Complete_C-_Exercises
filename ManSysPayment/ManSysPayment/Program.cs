using System.Globalization;
using System.Net.Sockets;
using ManSysPayment.Entities;

namespace ManSysPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("How many payments will be made? ");
                int paymentQuantity = int.Parse(Console.ReadLine());

                for (int i = 1; i <= paymentQuantity; i++)
                {
                    Console.WriteLine($"\nPayment data {i}:");
                    Console.Write("Choose payment form Ticket or Card (t/c): ");
                    char typePayment = char.Parse(Console.ReadLine().ToUpper());

                    Console.Write("Payment value: ");
                    double payment = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (typePayment == 'T')
                    {
                        Console.Write("Maturity date (dd/MM/yyyy): ");
                        DateTime maturity = DateTime.Parse(Console.ReadLine());
                        Ticket ticket = new Ticket(maturity, payment);
                        Console.WriteLine($"\nPayment value is: {ticket.CalculatePayment().ToString("C2", new CultureInfo("en-US"))}");
                    }
                    else
                    {
                        Console.Write("How many plost you will pay: ");
                        int plots = int.Parse(Console.ReadLine());
                        Card card = new Card(plots, payment);
                        Console.WriteLine($"\nPayment value is: {card.CalculatePayment().ToString("C2", new CultureInfo("en-US"))}");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Invalid data.");
            }
            
            

        }
    }
}
