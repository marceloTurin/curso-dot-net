using System;

namespace ExercicioQuarto {
    class Program {
        static void Main(string[] args) {

            Quarto[] vect = new Quarto[10];

            Console.WriteLine("How many room will be rented?");
            int qtdRoom = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdRoom; i++) {
                Console.WriteLine("Rent #1:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                vect[room] = new Quarto { Name = name, Email = email, Room = room };
            }

            Console.WriteLine("Busy rooms;");

            for (int i = 0; i < 10; i++) {
                if(vect[i] != null) {
                    Console.WriteLine(vect[i]);
                }
            }
        }
    }
}
