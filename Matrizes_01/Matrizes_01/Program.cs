using System;

namespace Matrizes_01 {
    class Program {
        static void Main(string[] args) {
            int M, N, i, j;
            int[,] matriz;

            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            matriz = new int[M, N];

            for (i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }


            Console.WriteLine("VALORES NEGATIVOS:");
            for (i = 0; i < M; i++) {
                for (j = 0; j < N; j++) {
                    if (matriz[i, j] < 0) {
                        Console.WriteLine(matriz[i,j]);
                    }
                }
            }


        }
    }
}
