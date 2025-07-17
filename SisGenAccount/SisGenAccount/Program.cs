using SisGenAccount.Entities;
using SisGenAccount.Entities.Exceptions;
using System.Globalization;

namespace SisGenAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string accountHolder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(accountNumber, accountHolder, withdrawLimit);
                account.Deposit(balance);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                Console.Write($"New balance: {account.Balance.ToString("C2", new CultureInfo("en-US"))}");
            }
            catch (DomainException ex)
            {
                Console.WriteLine($"Withdraw error: {ex.Message}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Account data error: {ex.Message}");
            }
        }
    }
}
