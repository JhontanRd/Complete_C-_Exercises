using SisGenTaxpayer.Entities;
using System.Globalization;

namespace SisGenTaxpayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int taxPayerQuantity = int.Parse(Console.ReadLine());

            List<Collaborator> listOfCollaborator = new List<Collaborator>();

            for (int i = 1; i <= taxPayerQuantity; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data: ");
                Console.Write("individual or Company (i/c): ");
                char type = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfCollaborator.Add(new Common(name, income, healthExpenditure));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int emplyees = int.Parse(Console.ReadLine());
                    listOfCollaborator.Add(new Company(name, income, emplyees));
                }
            }

            Console.WriteLine("\nTAXES PAID:");

            double totalTaxes = 0;
            foreach(Collaborator collaborator in listOfCollaborator)
            {
                Console.WriteLine($"{collaborator.Name}: {collaborator.CalculateTax().ToString("C2", new CultureInfo("en-US"))}");
                totalTaxes += collaborator.CalculateTax();
            }

            Console.WriteLine($"\nTOTAL TAXES: {totalTaxes.ToString("C2", new CultureInfo("en-US"))}");

        }
    }
}
