﻿using System;
using System.Globalization;

namespace Course {
    class Program {
        //Classes estaticas tem que ter atributos e classes estaticas;

        
        static void Main(string[] args) {

            Calculadora calc = new Calculadora();



            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));


        }


        

    }
}
