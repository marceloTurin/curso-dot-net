using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            //Pega o valor atual ou o default da variavel
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Verifica se a variavel tem valor retornando true ou false;
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            
            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");



        }
    }
}