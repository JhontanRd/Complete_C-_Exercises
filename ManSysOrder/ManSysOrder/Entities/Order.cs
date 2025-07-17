using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManSysOrder.Entities.Enums;

namespace ManSysOrder.Entities
{
    internal class Order
    {
        public OrderStatus OrderStatus { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Order(OrderStatus orderStatus)
        {
            OrderStatus = orderStatus;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public void UpdateOrderStatus(OrderStatus orderStatus) 
        {
            OrderStatus = orderStatus;
        }

        public double TotalOrderValue()
        {
            double total = 0;
            foreach (Product product in Products)
            {
                total += product.TotalValueProduct();
            }
            return total;
        }
    }
}
