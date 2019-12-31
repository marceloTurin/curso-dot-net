using ExpressaoLambda.Entities;
using ExpressaoLambda.Services;
using System;
using System.Collections.Generic;

namespace ExpressaoLambda {
    class Program {

       

        static void Main(string[] args) {

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(ProductTest);
            //list.RemoveAll(p => p.Price >= 100);

            foreach(Product p in list) {
                Console.WriteLine(p); 
            }

        }

        //Predicate tem que retornar um bool 

        public static bool ProductTest(Product p) {
            return p.Price >= 100.0;
        }
    }
}
