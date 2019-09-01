using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa");
            int qtdQuarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2]);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuarto);
            Console.WriteLine(precoProduto.ToString("F2"),CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));

            //Console.WriteLine(altura.ToString("F2"),CultureInfo.InvariantCulture);
          
        }
    }
}
