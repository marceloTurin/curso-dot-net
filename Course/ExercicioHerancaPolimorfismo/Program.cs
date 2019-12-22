using ExercicioHerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioHerancaPolimorfismo {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common,used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'c') {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'u') {
                    Console.Write("Manufacture date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }
                else {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }

            }

            Console.WriteLine();
            Console.WriteLine("Price Tags: ");
            foreach(Product product in list) {
                Console.WriteLine(product.priceTag());
            }

        }
    }
}
