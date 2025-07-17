using System.Threading.Channels;

namespace SisGen_Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Gerado pelo CHATGPT
            Desafio C#: Sistema de Controle de Eventos
            Enunciado:
                Crie um programa em C# para gerenciar eventos. Cada evento possui um nome, local, data e horário de início e término, além do nome do organizador.
                O programa deve permitir adicionar, editar, cancelar e visualizar eventos.

            ✅ Requisitos:
                Classe Evento:
                    Propriedades: Nome, Local, DataHoraInicio, DataHoraTermino (nullable), Organizador.
                    Use DateTime para representar as datas e horários.
                    Calcule a duração do evento usando TimeSpan.
                    Use Nullable para permitir que o horário de término seja opcional.
                    Crie um método que retorne as informações formatadas do evento, utilizando métodos para string.
                    Adicione um operador ternário para determinar se o evento está "Em andamento" ou "Finalizado".

                Funcionalidades no Programa Principal:
                    Adicionar Evento: Solicite todas as informações necessárias.
                    Editar Evento: Permita editar qualquer informação de um evento específico.
                    Cancelar Evento: Remova um evento da lista.
                    Exibir Eventos: Mostre todos os eventos com detalhes formatados.
                    Buscar Evento por Organizador: Permita buscar eventos pelo nome do organizador.

                Validações:
                    Garanta que a data de término (se informada) não seja anterior à data de início.
                    Trate entradas inválidas para datas, horários e números.

                🎯 Desafio Extra:
                    Adicione uma opção para exibir apenas os eventos que ainda não foram finalizados.
             */

            
            string action = null;

            List<Event> listOfEvents = new List<Event>();

            do
            {
                Console.WriteLine("\t==== Events Control ====\n");
                Console.Write("_Press (1) to [ADD] a new event.\n" +
                              "_Press (2) to [EDIT] a event.\n" +
                              "_Press (3) to [CANCEL] a event.\n" +
                              "_Press (4) to [CONSULT] event list.\n" +
                              "_Press (5) to [EXIT] and close.\n" +
                              "_Chose your option: ");
                action = Console.ReadLine();
                Console.WriteLine("=========================================");
                switch (action)
                {
                    case "1":
                        string isCorrect = null;
                        do
                        {
                            Console.WriteLine("\n========== ADD\n");
                            Console.Write("_Inform the organizer name: ");
                            string organizer = Console.ReadLine();
                            Console.Write("_Inform the event name: ");
                            string eventName = Console.ReadLine();
                            Console.Write("_Inform the event place: ");
                            string eventPlace = Console.ReadLine();
                            bool step1 = false, step2 = false; ;
                            DateTime eventStart = new DateTime();
                            do
                            {
                                Console.Write("_Inform the event date it is begginer (dd/MM/yyyy): ");
                                string dateEventStart = Console.ReadLine();
                                Console.Write("_Inform the time the event will start (HH:mm): ");
                                string timeEventStart = Console.ReadLine();

                                Authenticator judge = new Authenticator();
                                step1 = judge.IsVallidsValues(dateEventStart, timeEventStart);
                                if (step1)
                                {
                                    step2 = judge.FormatfForDateTime(dateEventStart, timeEventStart);
                                    if (step2)
                                    {
                                        eventStart = judge.GenerateDate(dateEventStart, timeEventStart);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n==========================================================\n" +
                                                          "[ERROR] This value is not accepted! The format is incorrect.." +
                                                          "\n==========================================================\n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n==========================================================\n" +
                                                      "[ERROR] This value is not accepted! Enter a valid date." +
                                                      "\n==========================================================\n");
                                }
                            } while (!step1 || !step2);

                            Console.Write("\n_Would you like to inform when the event will end? (Y) to YES or press any button to continue: ");
                            string endOfEvent = Console.ReadLine().ToUpper();

                            DateTime? endEvent = null;
                            if (endOfEvent == "Y")
                            {
                                Authenticator judge = new Authenticator();
                                bool isItPossible = false;
                                do 
                                {
                                    do
                                    {
                                        step1 = false;
                                        step2 = false;
                                        Console.Write("_Inform the event date it is finished (dd/MM/yyyy): "); // ADD metodo para validar o formato da data e se o valor é valido
                                        string dateEventEnd = Console.ReadLine();
                                        Console.Write("_Inform the time the event will end (HH:mm): ");
                                        string timeEventEnd = Console.ReadLine();

                                        step1 = judge.IsVallidsValues(dateEventEnd, timeEventEnd);
                                        if (step1)
                                        {
                                            step2 = judge.FormatfForDateTime(dateEventEnd, timeEventEnd);
                                            if (step2)
                                            {
                                                endEvent = judge.GenerateDate(dateEventEnd, timeEventEnd);
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n==========================================================\n" +
                                                                  "[ERROR] This value is not accepted! The format is incorrect.." +
                                                                  "\n==========================================================\n");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n==========================================================\n" +
                                                              "[ERROR] This value is not accepted! Enter a valid date." +
                                                              "\n==========================================================\n");
                                        }
                                    } while (!step1 || !step2);
                                    isItPossible = judge.IsItPossible(eventStart, endEvent);
                                    if (isItPossible)
                                    {
                                        Console.WriteLine("\n==========================================================\n" +
                                                          "[ERROR] The event end date cannot be before or equal to the event start date! Please enter a valid date." +
                                                          "\n==========================================================\n");
                                    }
                                } while (isItPossible);
                            }

                            Console.Write("\n_The informations is corrects? (Y) to continue or (N) to fill in again: ");
                            isCorrect = Console.ReadLine().ToUpper();
                            if (isCorrect == "Y")
                            {
                                if(endEvent == null)
                                {
                                    Event newEvent = new Event(organizer, eventName, eventPlace, eventStart);
                                    listOfEvents.Add(newEvent);
                                }
                                else
                                {
                                    Event newEvent = new Event(organizer, eventName, eventPlace, eventStart, endEvent);
                                    listOfEvents.Add(newEvent);
                                }
                                Console.WriteLine("\n_Success! the event was registered.");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else if (isCorrect == "N")
                            {
                                Console.WriteLine("\n==========================================================\n" +
                                                  "[ATENTION] Please enter the details again." +
                                                  "\n==========================================================");
                            }
                            else
                            {
                                Console.WriteLine("\n==========================================================\n" +
                                                  "[ERROR] This value is not accepted! Enter a valid value." +
                                                  "\n==========================================================\n");
                            }
                        } while (String.IsNullOrEmpty(isCorrect) || String.IsNullOrWhiteSpace(isCorrect) || isCorrect != "Y" || isCorrect == "N");
                        break;

                    case "2":
                        Console.WriteLine("\n========== EDIT\n");
                        List<Event> eventsToEdit = listOfEvents;
                        string repeat = null;
                        do
                        {
                            Console.Write("_Enter the name of the event organize or press (R) to return: ");
                            string name = Console.ReadLine().ToUpper();

                            if (name == "R")
                            {
                                Console.WriteLine("_Returning.");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                foreach (Event eventItem in eventsToEdit)
                                {
                                    if (name == eventItem.Organizer.ToUpper())
                                    {
                                        Console.Write($"_Organizer: {eventItem.Organizer}\n");
                                        Console.Write($"_Event name: {eventItem.EventName}\n");
                                        Console.Write($"_Event place: {eventItem.EventPlace}\n");
                                        Console.Write($"_Start of the event: {eventItem.StartOfTheEvent}\n");
                                        Console.Write($"_End of event: {eventItem.EndOfEvent}\n");
                                        Console.Write($"_Event in progress {eventItem.EventStatus}\n\n");

                                        string optionToUpdate = null;
                                        do
                                        {
                                            Console.Write("______________________\n" +
                                                          "_What will be altered:\n" +
                                                          "----------------------\n" +
                                                          "_Select (1) to update the person responsible.\n" +
                                                          "_Select (2) to update the event name\n" +
                                                          "_Select (3) to update the event location\n" +
                                                          "_Select (4) to update the event start date\n" +
                                                          "_Select (5) to update the event end date\n" +
                                                          "_Select (6) to cancel and return\n" +
                                                          "_Choose your option :");
                                            optionToUpdate = Console.ReadLine().ToUpper();
                                            Event eventDataUpdate = new Event();
                                            switch (optionToUpdate)
                                            {
                                                case "1":
                                                    Console.Write("\n_Inform the organizer name: ");
                                                    string organizer = Console.ReadLine();
                                                    if (!string.IsNullOrEmpty(organizer))
                                                    {
                                                        eventItem.UpadateOrganizer(organizer);
                                                        Console.WriteLine("_UPdate successfull.\n" +
                                                                          "==========================\n");
                                                    }
                                                    else
                                                    {
                                                        optionToUpdate = null;
                                                        Console.WriteLine("\n==========================================================\n" +
                                                                          "[ERROR] This value is not accepted! The format is incorrect.." +
                                                                          "\n==========================================================\n");
                                                    }

                                                    break;

                                                case "2":
                                                    Console.Write("\n_Inform the event name: ");
                                                    string eventNam = Console.ReadLine();
                                                    if (!string.IsNullOrEmpty(eventNam))
                                                    {
                                                        eventItem.UpdateEventName(eventNam);
                                                        Console.WriteLine("_UPdate successfull.\n" +
                                                                          "==========================\n");
                                                    }
                                                    else
                                                    {
                                                        optionToUpdate = null;
                                                        Console.WriteLine("\n==========================================================\n" +
                                                                          "[ERROR] This value is not accepted! The format is incorrect.." +
                                                                          "\n==========================================================\n");
                                                    }
                                                    break;

                                                case "3":
                                                    Console.Write("\n_Inform the event place: ");
                                                    string eventPla = Console.ReadLine();
                                                    if (!string.IsNullOrEmpty(eventPla))
                                                    {
                                                        eventItem.UpdatePlace(eventPla);
                                                        Console.WriteLine("_UPdate successfull.\n" +
                                                                          "==========================\n");
                                                    }
                                                    else
                                                    {
                                                        optionToUpdate = null;
                                                        Console.WriteLine("\n==========================================================\n" +
                                                                          "[ERROR] This value is not accepted! The format is incorrect.." +
                                                                          "\n==========================================================\n");
                                                    }
                                                    break;

                                                case "4":
                                                    Console.Write("\n_Inform the event date it is begginer (dd/MM/yyyy): ");
                                                    string dateEventStart = Console.ReadLine();
                                                    Console.Write("_Inform the time the event will start (HH:mm): ");
                                                    string timeEventStart = Console.ReadLine();
                                                    bool step1 = false, step2 = false; ;
                                                   
                                                    Authenticator judge = new Authenticator();
                                                    step1 = judge.IsVallidsValues(dateEventStart, timeEventStart);
                                                    if (step1)
                                                    {
                                                        step2 = judge.FormatfForDateTime(dateEventStart, timeEventStart);
                                                        if (step2)
                                                        {
                                                            DateTime eventStart = new DateTime();
                                                            eventStart = judge.GenerateDate(dateEventStart, timeEventStart);
                                                            eventItem.UpdateStartDate(eventStart);
                                                            Console.WriteLine("_UPdate successfull.\n" +
                                                                              "==========================\n");
                                                        }
                                                        else
                                                        {
                                                            optionToUpdate = null;
                                                            Console.WriteLine("\n==========================================================\n" +
                                                                              "[ERROR] This value is not accepted! The format is incorrect.." +
                                                                              "\n==========================================================\n");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        optionToUpdate = null;
                                                        Console.WriteLine("\n==========================================================\n" +
                                                                          "[ERROR] This value is not accepted! Enter a valid date." +
                                                                          "\n==========================================================\n");
                                                    }
                                                   

                                                    break;

                                                case "5":
                                                    Console.WriteLine("ATT final\n");
                                                    Console.Write("_Inform the event date it is finished (dd/MM/yyyy): ");
                                                    string dateEventEnd = Console.ReadLine();
                                                    Console.Write("_Inform the time the event will end (HH:mm): ");
                                                    string timeEventEnd = Console.ReadLine();

                                                    Authenticator judge2 = new Authenticator();
                                                    DateTime? endEvent = null;
                                                    step1 = judge2.IsVallidsValues(dateEventEnd, timeEventEnd);
                                                    if (step1)
                                                    {
                                                        step2 = judge2.FormatfForDateTime(dateEventEnd, timeEventEnd);
                                                        if (step2)
                                                        {
                                                            endEvent = judge2.GenerateDate(dateEventEnd, timeEventEnd);
                                                        }
                                                        else
                                                        {
                                                            optionToUpdate = null;
                                                            Console.WriteLine("\n==========================================================\n" +
                                                                              "[ERROR] This value is not accepted! The format is incorrect.." +
                                                                              "\n==========================================================\n");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        optionToUpdate = null;
                                                        Console.WriteLine("\n==========================================================\n" +
                                                                          "[ERROR] This value is not accepted! Enter a valid date." +
                                                                          "\n==========================================================\n");
                                                    }
                                                    bool isItPossible = judge2.IsItPossible(eventItem.StartOfTheEvent, endEvent);
                                                    if (isItPossible)
                                                    {
                                                        eventItem.UpdateEndDate(Convert.ToDateTime(endEvent));
                                                        Console.WriteLine("_UPdate successfull.\n" +
                                                                          "==========================\n");
                                                    }
                                                    else
                                                    {
                                                        optionToUpdate = null;
                                                        Console.WriteLine("\n==========================================================\n" +
                                                                          "[ERROR] The event end date cannot be before or equal to the event start date! Please enter a valid date." +
                                                                          "\n==========================================================\n");
                                                    }
                                                    break;

                                                case "6":
                                                    Console.WriteLine("_Returning.");
                                                    Thread.Sleep(2000);
                                                    Console.Clear();
                                                    break;

                                                default:
                                                    Console.WriteLine("\n==========================================================\n" +
                                                                      "[ERROR] This value is not accepted! Enter a valid value." +
                                                                      "\n==========================================================\n");
                                                    break;
                                            }
                                        } while (string.IsNullOrEmpty(optionToUpdate) || string.IsNullOrWhiteSpace(optionToUpdate) || !(Convert.ToInt32(optionToUpdate) >= 1 && Convert.ToInt32(optionToUpdate) <= 6));
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n==========================================================\n" +
                                                          "[ERROR] event not found! Enter a valid value." +
                                                          "\n==========================================================\n");
                                    }
                                }
                            }
                        } while (string.IsNullOrEmpty(repeat) || string.IsNullOrWhiteSpace(repeat) || repeat == "R"); /// nao esta send alterado o valor
                        break;

                    case "3":
                        Console.WriteLine("\n========== CANCEL\n");
                        List<Event> eventsToCancel = listOfEvents;
                        string cancel = null;
                        do
                        {
                            Console.Write("_Enter the name of the event organize: ");
                            string name = Console.ReadLine();

                            foreach(Event eventItem in eventsToCancel)
                            {
                                if(name == eventItem.Organizer)
                                {
                                    Console.Write($"\n_Organizer: {eventItem.Organizer}\n");
                                    Console.Write($"_Event name: {eventItem.EventName}\n");
                                    Console.Write($"_Event place: {eventItem.EventPlace}\n");
                                    Console.Write($"_Start of the event: {eventItem.StartOfTheEvent}\n");
                                    Console.Write($"_End of event: {eventItem.EndOfEvent}\n");
                                    Console.Write($"_Event in progress {eventItem.EventStatus}\n\n");

                                    Console.Write("_Do you want to cancel this event? (Y) to YES or (N) to NOT: ");
                                    cancel = Console.ReadLine().ToUpper();
                                    if (cancel == "Y")
                                    {
                                        eventItem.ChangeStatus();
                                        Console.WriteLine("_Event canceled.");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                    else if (cancel == "N")
                                    {
                                        cancel = "Y";
                                        Console.WriteLine("_Operation cancelled, returning to menu.");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n==========================================================\n" +
                                                          "[ERROR] This value is not accepted! Enter a valid value." +
                                                          "\n==========================================================\n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n==========================================================\n" +
                                                      "[ERROR] event not found! Enter a valid value." +
                                                      "\n==========================================================\n");
                                }
                            }
                        } while (String.IsNullOrEmpty(cancel) || String.IsNullOrWhiteSpace(cancel) || cancel != "Y");
                        break;

                    case "4":
                        Console.WriteLine("\n========== CONSULT\n");
                        List<Event> eventsFinished = listOfEvents.FindAll(finished => finished.EventStatus == false);
                        List<Event> ongoingEvents = listOfEvents.FindAll(inProgress => inProgress.EventStatus == true);

                        Console.WriteLine("_Ongoing events:\n");
                        foreach (Event toList in ongoingEvents)
                        {
                            Console.WriteLine(toList);
                            Console.WriteLine("\n=========================================\n");
                        }

                        Console.WriteLine("_Finished events:\n");
                        foreach (Event toList in eventsFinished)
                        {
                            Console.WriteLine(toList);
                            Console.WriteLine("\n=========================================\n");
                        }
                        Console.Write("Press any button to continue. ");
                        Console.ReadKey();
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;

                    case "5":
                        Console.WriteLine("\n\t==== END OF SYSTEM ====");
                        action = "0";
                        break;

                    default:
                        Console.WriteLine("\n==========================================================\n" +
                                          "[ERROR] This value is not accepted! Enter a valid value." +
                                          "\n==========================================================\n");
                        action = "1";
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            } while (String.IsNullOrEmpty(action) || String.IsNullOrWhiteSpace(action) || Convert.ToInt32(action) >= 1 && Convert.ToInt32(action) <= 5);
        }
    }
}
