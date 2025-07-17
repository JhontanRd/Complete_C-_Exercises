using ExercicioSecao08.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecao08.Entities
{
    internal class Order
    {
        public DateTime Moment {  get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status,Client client) 
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double tot = 0;
            foreach (OrderItem item in Items)
            {
                tot += item.SubTotal();
            }
            return tot;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append($" ({Client.BirthDate.ToShortDateString()}) - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine($"{item.Product.Name}, {item.Product.Price.ToString("C2",new CultureInfo("en-US"))}, Quantity: {item.Quantity}, Subtotal: {item.SubTotal().ToString("C2", new CultureInfo("en-US"))}");
            }
            sb.Append("Total price: ");
            sb.AppendLine($"{Total().ToString("C2", new CultureInfo("en-US"))}"); // Utilizar o C2 formata a saida no padrão monetário com o simbolo da moeda, ponto e virgula e o en-US especifica q vai ser no formato US
            return sb.ToString();
        }
    }
}
