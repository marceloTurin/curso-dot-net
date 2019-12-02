using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            //Verifica se a variavel é nula se for coloca o numero 5;
            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}