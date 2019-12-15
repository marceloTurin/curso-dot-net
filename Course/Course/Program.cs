using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.00) ? preco * 0.1 : preco * 0.85;

            Console.WriteLine(desconto);
            

        }



    }
}