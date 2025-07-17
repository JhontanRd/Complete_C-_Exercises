using System.IO;
using System.Runtime.Versioning;
using System.Xml.Linq;
using System.Globalization;

namespace ExArchive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory(); // Pega o caminho completo do executavel.
                                                           // D:\Meus sistemas\Meus programas aplicativos e sistemas\Programas C#\Exercicios\ExArchive\ExArchive\bin\Debug\net8.0

            int index = path.IndexOf("\\bin"); // Faz a contagem dos index até encontrar o texto \bin (que é a pasta).
            path = path.Substring(0, 98); // Troca o caminho completo pelo caminha até o diretótio rais do projeto sem pega o direitório bin em diante.
            path += @"\Out";
            Directory.CreateDirectory(path);

            Console.Write("Enter with a file name: ");
            string fileName = Console.ReadLine();

            string targetPath = path + @"\" + fileName + ".csv";

            try
            {
                if (!File.Exists(targetPath))
                {
                    using (FileStream fs = File.Create(targetPath))
                    {
                        Console.WriteLine($"+1 File added: {fileName}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Directory already exist.");
                }
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    Console.Write("How many items will be add: ");
                    int itemsQuantity = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= itemsQuantity; i++)
                    {
                        Console.Write($"Item #{i}: Enter with item data seprate for (,): ");
                        string newItem = Console.ReadLine();
                        sw.WriteLine(newItem);
                    }
                    Console.WriteLine("\n+All items added.");
                }

                string[] lines = File.ReadAllLines(targetPath);
                string newTargetPath = path + @"\" + fileName + " Total Cost.csv";
                string[] newLines = new string[lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] dataLine = lines[i].Split(',');
                    string result = (int.Parse(dataLine[2]) * double.Parse(dataLine[1])).ToString("C2", CultureInfo.InvariantCulture); // Funcionou mas nãoi esta muliplando o valor
                    newLines[i] = $"{dataLine[1]},{result}";
                }
                File.AppendAllLines(newTargetPath, newLines);
                Console.WriteLine("\n\nTotal Value");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error! {e.Message}");
            }
        }
    }
}
