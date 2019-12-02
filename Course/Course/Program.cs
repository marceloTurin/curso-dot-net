using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            //Adiciona no final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            //Adiciona na posição do index passsada;
            list.Insert(2, "Marco");

            foreach(string obj in list) {
                Console.WriteLine(obj);
            }

            //Mostra o tamanho da lista
            Console.WriteLine("List count: "+ list.Count);


            //Expressao lambda que retorna a primeira pessoa com o nome A;
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': "+ s1);

            //Expressao lambda que retorna a ultima pessoa com nome A;
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            //Expressao labmda que retona a primeira posicao que começa com A
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Firt position 'A' "+ pos1);


            //Expressao lambda que retorna a ultima posicao que começa com B
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A' " + pos2);


            //Expressao lambda que retorna os nomes com 5 caractere
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------");

            foreach(string obj in list2) {
                Console.WriteLine(obj);
            }

            //Remove um nó da lista passando um parametro
            list.Remove("Alex");

            Console.WriteLine("--------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }


            //Remove um nó da lista passando a posicao
            // list.RemoveAt(3);

            
            //Remove da lista a partir da posição 2 dois elementos
            //list.RemoveRange(2,2);

           
            //Remove todos os nó da lista contendo a letra M
            list.RemoveAll(x=> x[0] == 'M');

            Console.WriteLine("--------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }


            //Remove o elemento pela posição
            list.RemoveAll(x => x[0] == 'M');

            Console.WriteLine("--------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }


        }



    }
}