using ExercicioComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioComposicao.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order() {

        }

        public Order(DateTime moment, OrderStatus status,Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Item.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Item.Remove(item);
        }

        public double Total() {

            double total = 0;

            foreach (OrderItem item in Item) {
                total += item.Price * item.Quantity;
            }

            return total;
        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy hh:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" ");
            sb.Append(Client.birthDate.ToString("dd/MM/yyyy"));
            sb.Append(" - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");
            foreach(OrderItem item in Item) {
                sb.Append(item.Product.Name);
                sb.Append(", $ ");
                sb.Append(item.Price);
                sb.Append(" Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(" Subtotal:  ");
                sb.AppendLine(item.subTotal().ToString());
            }
            sb.Append("Total price: ");
            sb.Append(Total());

            return sb.ToString();

        }
    }
}
