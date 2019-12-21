using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioComposicao.Entities;
using ExercicioComposicao.Entities.Enums;

namespace ExercicioComposicao {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birth);

           

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus ordemStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items to this order?");
            int qtdItens = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, ordemStatus, client);

            for (int i = 1; i <= qtdItens; i++) {

                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice,product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
