using SisGenParking.Entities;
using SisGenParking.Entities.Enums;
using System.Globalization;

namespace SisGenParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Enunciado do Exercício:

            Você deve criar um sistema para gerenciar um estacionamento, com as seguintes características:
             I- Um Estacionamento pode ter vários Carros.
             I- Cada Carro pode ter uma Categoria (com enumeração: Economico, Esportivo, Luxo).
             I- O Estacionamento tem um método para calcular o valor total do estacionamento, 
                que depende da Categoria do carro e do tempo em que ele está estacionado (o tempo é representado por um número de horas).

            A Categoria de um carro determina a taxa por hora do estacionamento:
             I- Economico: R$ 10/h
             I- Esportivo: R$ 20/h
             I- Luxo: R$ 30/h

            Você deve implementar classes para:
             I- Estacionamento: que tem uma lista de Carros.
             I- Carro: que possui a Categoria e o tempo de estacionamento (em horas).
             I- Categoria: que é um enum com as três opções mencionadas.
             */
            Console.WriteLine("PARKING\n");
            Parking parking = new Parking();
            Console.Write("How many vacancies will be filled? ");
            int quantity = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"\nVacancy #{i}:");
                Console.Write("What is the car category (Economic, Sporty, Luxury): ");
                Category catCarr = Enum.Parse<Category>(Console.ReadLine());
                Carr carr = new Carr(DateTime.Now, catCarr);
                parking.AddCarr(carr);
                Console.WriteLine("\nVacancy successfully filled!\n");
            }

            Console.WriteLine("Occupied parking spaces:\n");
            foreach (Carr carr in parking.Carrs)
            {
                Console.WriteLine(carr);
            }
            Console.WriteLine($"TOTAL: {parking.CalculateTotal().ToString("C2", new CultureInfo("en-US"))}");
        }
    }
}
