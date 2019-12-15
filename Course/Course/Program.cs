using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper(); // Converte todo mundo para maiusculo
            string s2 = original.ToLower(); // Converte todo mundo para o minusculo
            string s3 = original.Trim(); // Apaga os espaço em brancos
            int n1 = original.IndexOf("bc"); // Procura a primeira posição da string 
            int n2  = original.LastIndexOf("bc"); //Procura a ultima posição da string
            string s4 = original.Substring(3); // Recorta a string a partir da posição 3
            string s5 = original.Substring(3, 5); //Recorta a string a partir da posição 3 e somente os 5 caracteres seguintes
            string s6 = original.Replace('a','x'); //Troca todos os caracteres a por x
            string s7 = original.Replace("abc", "xy"); //Troca todos as string abc por xy

            bool b1 = String.IsNullOrEmpty(original); // Testa se a variavel é nula ou vazio
            bool b2 = String.IsNullOrWhiteSpace(original); //Testa se a variavel é nula ou tem varios espaços em brancos



            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3):"  +s4);
            Console.WriteLine("Substring(3,5): -" + s5+"-");
            Console.WriteLine("Replace('a','x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc','xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: "+ b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);





        }



    }
}