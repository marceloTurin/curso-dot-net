using ExpressaoLambda.Entities;
using ExpressaoLambda.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace ExpressaoLambda {
    class Program {

        static void Main(string[] args) {

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<ProductNew> list =  new List<ProductNew>();

            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] fields = sr.ReadLine().Split(',');

                    string name = fields[0];
                    double price = double.Parse(fields[1],CultureInfo.InvariantCulture);

                    list.Add(new ProductNew(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Average price: {avg.ToString("F2",CultureInfo.InvariantCulture)} ");

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach (string name in names) {
                Console.WriteLine(name);
            }


        }


    }
}
