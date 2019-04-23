using System.Globalization;
using System.Text;
using System;
using System.Collections.Generic;


namespace Exercicio211.Entities
{
    class Order
    {
        public Client Client { get; set; }
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; } = OrderStatus.Processing;

        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Order() { }
        public Order(Client client, OrderStatus status)
        {
            Client = client;
            Status = status;
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));

            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());

            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());

            sb.AppendLine("Order Items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));


            return sb.ToString();
        }
    }
}