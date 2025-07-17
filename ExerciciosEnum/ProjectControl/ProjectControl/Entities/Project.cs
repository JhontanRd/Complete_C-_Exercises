using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectControl.Entities.Enums;

namespace ProjectControl.Entities
{
    internal class Project
    {
        public string ProjectName { get; set; }
        public Status ProjectStatus { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Project() { }

        public Project(string projectName, Status projectStatus)
        {
            ProjectName = projectName;
            ProjectStatus = projectStatus;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PROJECT:");
            sb.AppendLine($"- Project name: {ProjectName}");
            sb.AppendLine($"- Project status: {ProjectStatus}");
            sb.AppendLine("\nLIST OF EMPLOYESS:");
            foreach (Employee employee in Employees)
            {
                sb.AppendLine($"- Employee's name: {employee.EmployeeName}");
                sb.AppendLine($"- Employee's position: {employee.Position}\n");
            }
            return sb.ToString();
        }
    }
}
