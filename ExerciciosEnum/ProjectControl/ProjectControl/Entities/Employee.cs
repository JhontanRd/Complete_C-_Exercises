using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectControl.Entities
{
    internal class Employee
    {
        public string EmployeeName { get; set; }
        public string Position { get; set; }

        public Employee() { }

        public Employee(string employeeName, string position)
        {
            EmployeeName = employeeName;
            Position = position;
        }

    }
}
