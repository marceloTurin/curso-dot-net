using System;
using System.Globalization;

namespace Course {
    class Program {
        //Classes estaticas tem que ter atributos e classes estaticas;

        static double Pi = 3.14;
        static void Main(string[] args) {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));


        }

        static double Circunferencia(double raio) {
            return 2.0 * Pi * raio;
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

        

    }
}
