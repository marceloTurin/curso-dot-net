using ExpressaoLambda.Entities;
using ExpressaoLambda.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressaoLambda {
    class Program {

       

        static void Main(string[] args) {

            //Specify the data source

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Define the query expression

            // o where filtra e o select seleciona os resultado do where
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute the query

            foreach (int x in result) {
                Console.WriteLine(x);
            }

        }

        static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }

 
    }
}
