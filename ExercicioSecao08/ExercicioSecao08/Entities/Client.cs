using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecao08.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() { }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        // Implementei o ToString para testar
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: ");
            sb.AppendLine(Name);
            sb.Append("Email: ");
            sb.AppendLine(Email);
            sb.Append("Bith Date: ");
            sb.AppendLine(BirthDate.ToShortDateString());
            return sb.ToString();
        }
    }
}
