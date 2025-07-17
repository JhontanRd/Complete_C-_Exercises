using System;
using System.Resources;
using System.Threading;

namespace Sis_Gen_SalasReuniao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício
                Crie um programa em C# para gerenciar um sistema de reservas de salas de reunião.
                O programa deve permitir a criação, edição e cancelamento de reservas,
                além de exibir informações sobre as reservas atuais.
                As reservas devem conter informações sobre a sala, o horário de início e término, e o responsável pela reserva.

                Requisitos
                1. Crie uma classe Reserva com as propriedades Sala, HorarioInicio, HorarioTermino e Responsavel.
                2. Utilize DateTime para representar os horários de início e término das reservas.
                3. Calcule a duração da reserva utilizando TimeSpan.
                4. Permita que a propriedade HorarioTermino seja nullable.
                5. Formate a saída das informações da reserva utilizando métodos para strings.
                6. Utilize o operador ternário para determinar se a reserva está em andamento ou finalizada.
             */
            int action = 0;

            List<Reserve> listOfReserves = new List<Reserve>();

            do
            {
                DateTime dataHoraAtual = DateTime.Now;
                string dataAtual = dataHoraAtual.ToLongDateString();
                string horaAtual = dataHoraAtual.ToShortTimeString();
                Console.WriteLine($"{dataAtual} {horaAtual}\n\n\t== RESERVE MANAGER ==\n");

                Console.Write("(1) To do reserve.\n" +
                              "(2) To see reserves.\n" +
                              "(3) To edit a reserve.\n" +
                              "(4) To cancel a reserve.\n" +
                              "(5) To close system\n" +
                              "Chose your option: ");
                action = int.Parse(Console.ReadLine());
                Console.WriteLine("\n===================================\n");

                switch (action)
                {
                    case 1:
                        Console.WriteLine("== NEW RESERVATION ==");
                        Console.Write("\nEnter with your name: ");
                        string name = Console.ReadLine();
                        Console.Write("Chose your room: ");
                        int room = int.Parse(Console.ReadLine());
                        char? checkOuYesOrNo = null;
                        string checkOutHour = null;

                        do
                        {
                            Console.Write("Want inform the hour of check-out (Y) to YES or (N) to no: ");
                            checkOuYesOrNo = char.Parse(Console.ReadLine().ToUpper());
                            if (checkOuYesOrNo == 'Y')
                            {
                                Console.Write("Enter with the date and hour of check-out (dd/MM/yyyy HH:mm:ss): ");
                                checkOutHour = Console.ReadLine();
                                break;
                            }
                            else if (checkOuYesOrNo == 'N')
                            {
                                Console.WriteLine("The value will be calculated when you do a check-out.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("[ERROR] Invalid value! Enter again.");
                            }
                        } while (checkOuYesOrNo == 'Y' || checkOuYesOrNo == 'N');
                        DateTime checkIn = DateTime.Now;
                        DateTime? checkOut;
                        if (String.IsNullOrEmpty(checkOutHour))
                        {
                            checkOut = null;
                        }
                        else
                        {
                            checkOut = DateTime.Parse(checkOutHour);
                        }
                        Reserve newReserve = new Reserve(name, room, checkIn, checkOut);
                        listOfReserves.Add(newReserve);
                        Console.WriteLine("\nSuccess, reserve registred!");
                        Thread.Sleep(3000); // Congela a tela por 3 segundos.
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("== LIST OF RESERVES ==\n\n");
                        foreach (Reserve reserves in listOfReserves)
                        {
                            Console.WriteLine(reserves);
                            Console.WriteLine("\n=============================================\n");
                        }
                        Console.Write("Press any button to continue. ");
                        Console.ReadKey();
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("== EDIT RESERVE ==");

                        List<Reserve> listOfReserveTemporary = listOfReserves;
                        Console.Write("\nEnter with responsible name: ");
                        name = Console.ReadLine();
                        foreach(Reserve res in listOfReserveTemporary)
                        {
                            if (name == res.Responsible)
                            {
                                Console.WriteLine($"\nResponsibli name: {res.Responsible} | Room Nº: {res.Room}");
                                Console.WriteLine($"Check-In: {res.StartTime}");
                                Console.WriteLine($"Check-out: {res.EndTime}\n");

                                int? editOpt = null;
                                do
                                {
                                    Console.Write("(1) To edit room nº.\n" +
                                              "(2) To edit check-out.\n" +
                                              "(3) To edit both.\n" +
                                              "Chose your option: ");
                                    editOpt = int.Parse(Console.ReadLine());
                                    if (editOpt == 1)
                                    {
                                        Console.Write("\nEnter with a new nº room: ");
                                        room = int.Parse(Console.ReadLine());
                                        res.UpdateRoom(room);
                                    }
                                    else if (editOpt == 2)
                                    {
                                        Console.Write("\nEnter witha new check-out hour (dd/MM/yyyy HH:mm:ss): ");
                                        checkOutHour = Console.ReadLine();
                                        res.UpdateCheckOut(DateTime.Parse(checkOutHour));
                                    }
                                    else if (editOpt == 3)
                                    {
                                        Console.Write("\nEnter with a new nº room: ");
                                        room = int.Parse(Console.ReadLine());
                                        Console.Write("Enter with a new check-out hour (dd/MM/yyyy HH:mm:ss): ");
                                        checkOutHour = Console.ReadLine();
                                        res.UpdateRoomAndCheckOut(room, DateTime.Parse(checkOutHour));
                                        
                                    }
                                    else if ((editOpt < 1 || editOpt > 3) || (editOpt == null))
                                    {
                                        Console.WriteLine("\n==================================\n" +
                                                          "[ERROR] Invalid value! Enter again.\n" +
                                                          "==================================\n");
                                    }
                                } while ((editOpt != 1 && editOpt != 2 && editOpt != 3) || (editOpt == null));
                                Console.WriteLine("\nSuccess, register updated");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("== CANCEL RESERVE ==");

                        listOfReserveTemporary = listOfReserves;
                        Console.Write("\nEnter with responsible name to cancel reserve: ");
                        name = Console.ReadLine();
                        foreach(Reserve res in listOfReserveTemporary)
                        {
                            if(name == res.Responsible)
                            {
                                if (res.ReserveStatus)
                                {
                                    if (res.EndTime == null)
                                    {
                                        DateTime since = res.StartTime;
                                        string timeToShare = since.ToLongTimeString();
                                        string[] parts = timeToShare.Split(':');
                                        TimeSpan time = new TimeSpan(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
                                        DateTime until = DateTime.Now;
                                        DateTime duration = until.Subtract(time);
                                        listOfReserveTemporary.Remove(res);
                                        Console.WriteLine("Your reserve has been canceled.");
                                        Console.WriteLine($"Total hours at the establishment: {duration}");
                                        break;
                                    }
                                    else
                                    {
                                        DateTime since = res.StartTime;
                                        string sinceToShare = since.ToLongTimeString();
                                        string[] sinceParts = sinceToShare.Split(':');
                                        TimeSpan newSinceTime = new TimeSpan(int.Parse(sinceParts[0]), int.Parse(sinceParts[1]), int.Parse(sinceParts[2]));
                                        
                                        DateTime until = (DateTime) res.EndTime;
                                        string untilToShare = until.ToLongTimeString();
                                        string[] untilParts = untilToShare.Split(':');
                                        TimeSpan newUntilTime = new TimeSpan(int.Parse(untilParts[0]), int.Parse(untilParts[1]), int.Parse(untilParts[2]));
                                        
                                        TimeSpan duration = newUntilTime.Subtract(newSinceTime);
                                        DateTime day = DateTime.Now;
                                        string finalDate = $"{day.ToString("yyyy/MM/dd")} {duration}".Replace(':', ' ').Replace('/', ' ');
                                        string[] finalDateToShare = finalDate.Split(' ');
                                        listOfReserveTemporary.Add(res);
                                        DateTime definitive = new DateTime(int.Parse(finalDateToShare[0]), int.Parse(finalDateToShare[1]), int.Parse(finalDateToShare[2]),
                                                                           int.Parse(finalDateToShare[3]), int.Parse(finalDateToShare[4]), int.Parse(finalDateToShare[5]));
                                        Console.WriteLine($"Total hours at the establishment: {definitive.ToShortTimeString()}");
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n==================================\n" +
                                                  "[ERROR] Invalid value! Enter again.\n" +
                                                  "==================================\n");
                            }
                        }
                        Console.WriteLine("\nSuccess, register canceled.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("[END OF SYSTEM]");
                        break;
                }
            } while (action > 0 && action < 5);
        }
    }
}
