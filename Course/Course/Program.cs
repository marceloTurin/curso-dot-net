using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {

            /*Tipos de retorno de datas*/
            DateTime d1 = DateTime.Now; //Retorna data e hora atual
            DateTime d2 = new DateTime(2019,12,25); //Definindo uma data
            DateTime d3 = new DateTime(2019, 12, 25, 20, 45, 03); //Definindo a hora
            DateTime d4 = new DateTime(2019, 12, 25, 20, 45, 03,500); //Definindo o milisegundo
            DateTime d5 = DateTime.Today; // Retorna a data atual com a hora zerada 
            DateTime d6 = DateTime.UtcNow; // Retorna a hora universal 

            /*Tipos de parametros de datas*/
            DateTime d7 = DateTime.Parse("2008-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("21/08/2019");
            DateTime d10 = DateTime.Parse("21/08/2020 13:14:59");

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);

        }



    }
}