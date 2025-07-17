using ProjectControl.Entities;
using ProjectControl.Entities.Enums;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Project> listOfProjects = new List<Project>();
            string option = null;

            do
            {
                Console.WriteLine("\t....PROJECTS CONTROL....\n");

                Console.Write("- Press (1) to Add new Project.\n" +
                              "- Press (2) to Remove Project or Employee.\n" +
                              "- Press (3) to See all Projects.\n" +
                              "- Press (4) To Exit.\n" +
                              "- Choose your option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("\n\t....Adding Project....\n");
                        Console.Write("- How many projects will be added? ");
                        int quantityProjctAdded = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= quantityProjctAdded; i++)
                        {
                            Console.WriteLine($"\nProject #{i}");
                            Console.Write("- Enter with a project's name: ");
                            string projectName = Console.ReadLine();
                            
                            string statusType = null;
                            Status status = new Status();
                            do
                            {
                                Console.Write("- Status of a project can be:\n" +
                                          "(0) to Stopped\n" +
                                          "(1) to ScopeDefinition\n" +
                                          "(2) to Planning\n" +
                                          "(3) to Development\n" +
                                          "(4) to Testing\n" +
                                          "(5) to Completed\n" +
                                          "- Enter with a status's project: ");
                                statusType = Console.ReadLine();

                                if (statusType == "0")
                                {
                                    status = Status.Stopped;
                                    break;
                                }
                                else if (statusType == "1")
                                {
                                    status = Status.ScopeDefinition;
                                    break;
                                }
                                else if (statusType == "2")
                                {
                                    status = Status.Planning;
                                    break;
                                }
                                else if (statusType == "3")
                                {
                                    status = Status.Development;
                                    break;
                                }
                                else if (statusType == "4")
                                {
                                    status = Status.Testing;
                                    break;
                                }
                                else if (statusType == "5")
                                {
                                    status = Status.Completed;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------\n* [ERROR] Enter with a valid status.\n-------------------------------------\n");
                                }
                            } while (string.IsNullOrEmpty(statusType) || string.IsNullOrWhiteSpace(statusType) || Convert.ToBoolean((int)statusType[0]) || (Convert.ToInt32(statusType) < 0 && Convert.ToInt32(statusType) > 5));
                            Project project = new Project(projectName, status);
                            Console.Write("\n- How many employees are there on the project? ");
                            int quantityEmployees = int.Parse(Console.ReadLine());
                            for(int j = 1; j <= quantityEmployees; j++)
                            {
                                Console.WriteLine($"\nEmployee #{j}");
                                Console.Write("- Enter with a employeer's name: ");
                                string employeeName = Console.ReadLine();
                                Console.Write("- Enter with a employeer's position: ");
                                string employeePosition = Console.ReadLine();
                                Employee employee = new Employee(employeeName, employeePosition);
                                project.AddEmployee(employee);                                
                            }
                            listOfProjects.Add(project);
                            Console.WriteLine("\n===============================================");
                        }
                        Console.WriteLine("\n- Registration completed.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("\n\t....Remove Project or Employee....\n");
                        Console.Write("- Press (1) to remove Project.\n" +
                                      "- Press (2) to remove Employee.\n" +
                                      "- Press any button to Cancel and return.\n" +
                                      "- Chosse your option: ");
                        string optionToRemove = Console.ReadLine();

                        if (optionToRemove ==  "1")
                        {
                            int cont = 1;
                            foreach (Project project in listOfProjects)
                            {
                                Console.WriteLine($"- Project #{cont}: {project.ProjectName}");
                                cont++;
                            }
                            Console.Write("\n- Enter with a projet's name that will be removed or press any button to return: ");
                            string toRemove = Console.ReadLine();
                            foreach (Project project in listOfProjects)
                            {
                                if (project.ProjectName == toRemove)
                                {
                                    Console.Write($"\n{project}");
                                    Console.Write("- Do you want remove this project? (Y) to Yes or press any button to cancel: ");
                                    string remove = Console.ReadLine().ToUpper();
                                    if (remove == "Y")
                                    {
                                        listOfProjects.Remove(project);
                                        Console.WriteLine("\n- Project removed.");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                }
                            }
                            Console.Clear();
                        }
                        else if (optionToRemove == "2")
                        {
                            int cont = 1;
                            Console.WriteLine();
                            foreach (Project project in listOfProjects)
                            {
                                Console.WriteLine($"- Project #{cont}: {project.ProjectName}");
                                cont++;
                            }
                            Console.Write("\n- Enter with a projet's name that of where a employee will removed or press any button to return: ");
                            string toRemove = Console.ReadLine();
                            foreach(Project project in listOfProjects)
                            {
                                if(project.ProjectName == toRemove)
                                {
                                    Console.WriteLine();
                                    foreach (Employee employee in project.Employees)
                                    {
                                        Console.WriteLine($"Employee: {employee.EmployeeName}");
                                    }
                                    Console.Write("\n- Enter with employee's name that will be removed: ");
                                    string employeeToRemove = Console.ReadLine();
                                    foreach (Employee employee in project.Employees)
                                    {
                                        if(employee.EmployeeName == employeeToRemove)
                                        {
                                            project.RemoveEmployee(employee);
                                            Console.WriteLine("\n- Employee removed.");
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("-------------------------------------\n* [ERROR] Enter with a valid value.\n-------------------------------------");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        break;

                    case "3":
                        Console.WriteLine("\n\t....List Of Projects....\n");
                        foreach (Project project in listOfProjects)
                        {
                            Console.Write(project);
                            Console.WriteLine("===============================================\n");
                        }
                        Console.WriteLine("- Press any button to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.WriteLine("\n\t....END OF SYSTEM....");
                        option = "0";
                        break;

                    default:
                        if (string.IsNullOrEmpty(option) || string.IsNullOrWhiteSpace(option) || (Convert.ToInt32(option) < 1 || Convert.ToInt32(option) > 4))
                        {
                            Console.WriteLine("-------------------------------------\n* [ERROR] Enter with a valid value.\n-------------------------------------");
                            Thread.Sleep(3000);
                            Console.Clear();
                            option = "4";
                        }
                        break;
                }
            } while (string.IsNullOrEmpty(option) || string.IsNullOrWhiteSpace(option) || (Convert.ToInt32(option) >= 1 && Convert.ToInt32(option) <= 4));
        }
    }
}
