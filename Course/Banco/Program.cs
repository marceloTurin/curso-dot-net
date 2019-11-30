using System;

namespace Banco {
    class Program {
        static void Main(string[] args) {

            ContaBancaria c;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            char deposito = char.Parse(Console.ReadLine());

            if (deposito == 's') {
                Console.Write("Entre com o valor do depósito: ");
                double saldo = double.Parse(Console.ReadLine());

                c = new ContaBancaria(numero,nome,saldo);
            } else {
                c = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("Dados da Conta: " + c);

            Console.Write("Entre um valor para depótiso: ");
            double valor = double.Parse(Console.ReadLine());

            c.Deposito(valor);
            Console.WriteLine("Dados da Conta Atualizado: " + c);

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());

            c.Saque(valor);
            Console.WriteLine("Dados da Conta Atualizado: " + c);

        }
    }
}
