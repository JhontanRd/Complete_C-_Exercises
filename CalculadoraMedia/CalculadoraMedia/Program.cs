using System.Globalization;
namespace CalculadoraMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA\n");
            Console.WriteLine("Digite uma sequência qualquer de números inteiros separadas por espaço.");
            Console.Write("Sequência: ");
            string[] sequencia = Console.ReadLine().Split(' ');

            int[] valores = new int[sequencia.Length];
            int sum = 0;

            for (int i = 0; i < sequencia.Length; i++)
            {
                valores[i] = int.Parse(sequencia[i]);
                sum += valores[i];
            }
            double media = (double )sum / valores.Length;

            Console.WriteLine($"A Me entre os valores digitados é de {media.ToString("F2", CultureInfo.InvariantCulture)}");

            int quantModa = 0;
            string comeclatura = null;
            int auxiliar = 0;

            List<int> paraComparar = new List<int>();

            for(int i = 0; i < valores.Length; i++)
            {
                paraComparar.Add(valores[i]);
            }

            foreach(int i in paraComparar)
            {
                paraComparar.FindAll(numb => i == numb);
            }

            if(quantModa == 0 )
            {
                Console.WriteLine("A sequencia é Amodal.");
            }
            else if (quantModa == 1)
            {
                Console.WriteLine("A sequencia possui Moda");
            }
            else if(quantModa == 2)
            {
                Console.WriteLine("A sequencia é Bimodal");
            }
            else
            {
                Console.WriteLine("A sequencia é Multimodal");
            }


        }
    }
}
