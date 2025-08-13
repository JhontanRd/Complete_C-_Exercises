namespace ExVotations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("-> Enter file full path: ");
            string path = Console.ReadLine();
            //C:\temp\in.txt

            Dictionary<string, int> candidates = new Dictionary<string, int>();
            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] candidateData = sr.ReadLine().Split(',');
                        string name = candidateData[0];
                        int votes = int.Parse(candidateData[1]);

                        if (candidates.ContainsKey(name))
                        {
                            candidates[name] += votes;
                        }
                        else
                        {
                            candidates.Add(name, votes);
                        }
                    }
                }

                Console.WriteLine();
                foreach (KeyValuePair<string, int> item in candidates)
                {
                    Console.WriteLine($"-> {item.Key}: {item.Value}");
                }
            }
            catch (IOException ex)
            {

                Console.WriteLine("-> [ERROR] FIle not found. " + ex.Message);
            }
        }
    }
}
