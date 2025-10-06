using ShowEmployeeData.Entities;
using System.Globalization;

namespace ShowEmployeeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise Employee\n");

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Email of people whose salary is more than {value.ToString("C2", new CultureInfo("pt-BR"))}:");

            var userEmails = employees.Where(e => e.Salary > value).OrderBy(e => e.Email).Select(e => e.Email).ToList();

            userEmails.ForEach(e => Console.WriteLine(e));

            double total = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine($"Sum os salary of people whose name starts with 'M': {total.ToString("C2", new CultureInfo("pt-BR"))}");
        }
    }
}
