using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quanos números inteiros você vai digitar: ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for(int i = 1; i <= N; i++) {
                Console.Write($"Valor #{i} ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");

        }

    }
}
