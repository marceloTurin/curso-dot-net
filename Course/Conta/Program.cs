using System;

namespace Banco {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            char deposito = char.Parse(Console.ReadLine());

            if(deposito == 's') {
                Console.Write("Entre com o valor do depósito");
                double saldo = double.Parse(Console.ReadLine());

                ContaBancaria c = new ContaBancaria();
            }

        }
    }
}
