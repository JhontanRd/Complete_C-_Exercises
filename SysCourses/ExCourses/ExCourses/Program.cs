namespace ExCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("-> How many students for course A: ");
            int quantityCourse = int.Parse(Console.ReadLine());
            for(int i = 0; i < quantityCourse; i++)
            {
                Console.Write("-> Enter with student code: ");
                int code = int.Parse(Console.ReadLine());
                courseA.Add(code);
            }
            Console.WriteLine();

            Console.Write("-> How many students for course B: ");
            quantityCourse = int.Parse(Console.ReadLine());
            for(int i = 0; i < quantityCourse; i++)
            {
                Console.Write("-> Enter with student code: ");
                int code = int.Parse(Console.ReadLine());
                courseB.Add(code);
            }
            Console.WriteLine();

            Console.Write("-> How many students for course C: ");
            quantityCourse = int.Parse(Console.ReadLine());
            for(int i = 0; i < quantityCourse; i++)
            {
                Console.Write("-> Enter with student code: ");
                int code = int.Parse(Console.ReadLine());
                courseC.Add(code);
            }
            Console.WriteLine();

            HashSet<int> students = new HashSet<int>(courseA);
            students.UnionWith(courseB);
            students.UnionWith(courseC);
            int total = students.Count();

            Console.Write($"-> Total students: {total}");

        }
    }
}
