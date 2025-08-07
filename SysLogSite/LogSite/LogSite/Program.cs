using System.IO;
using LogSite.Entities;

namespace LogSite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter with full path: ");
            string directory = Console.ReadLine();
            //string directory = @"C:\temp\in.txt";

            HashSet<LogRecord> log = new HashSet<LogRecord>();
            try
            {
                using (StreamReader sr = File.OpenText(directory))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime intant = DateTime.Parse(line[1]);

                        log.Add(new LogRecord { Username = name, Instante = intant });
                    }
                }
                int numbAccess = log.Count;
                Console.WriteLine($"Total users: {numbAccess}");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            


        }
    }
}
