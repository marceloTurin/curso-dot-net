using System;

namespace ExercicioMatrizes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o tamanho da matriz");
            string[] tamanho = Console.ReadLine().Split(' ');

            int line = int.Parse(tamanho[0]);
            int colunm = int.Parse(tamanho[1]);

            int[,] mat = new int[line, colunm];

            for (int i = 0; i < line; i++) {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < colunm; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine();


            for (int i = 0; i < line; i++) {

                for (int j = 0; j < colunm; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Escolha um número da matriz: ");
            int number = int.Parse(Console.ReadLine());


            for (int i = 0; i < line; i++) {

                for (int j = 0; j < colunm; j++) {
                    if (mat[i,j] == number) {

                        Console.WriteLine("Position "+ i + "," + j);

                       if( j > 0) {
                            Console.WriteLine("Left: " + mat[i, j -1]);
                        }

                       if(i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }

                       if(j < colunm - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                       }

                       if(i < line - 1) {
                            Console.WriteLine("Down: " + mat[i + 1,j]);
                        }

                        Console.WriteLine("------------------------------------");
                        
                    }
                }
                
            }

           


        }
    }
}
