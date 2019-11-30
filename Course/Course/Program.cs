using System;
using System.Globalization;

namespace Course {
    class Program {
        //Classes estaticas tem que ter atributos e classes estaticas;

        
        static void Main(string[] args) {



            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


        }


        

    }
}
