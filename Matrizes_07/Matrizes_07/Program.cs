using System;

namespace Matrizes_07 {
    class Program {
        static void Main(string[] args) {
            int M, N, i, j, fila;
            int[,] matriz;
            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());

            matriz = new int[M, N];

            for (i = 0; i < M; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            fila = int.Parse(Console.ReadLine());

            fila -= 1;

            int ultimoDaFila = matriz[fila, N - 1];

            for (j = N - 1; j > 0; j--) {
                matriz[fila, j] = matriz[fila, j - 1];
            }

            matriz[fila, 0] = ultimoDaFila;

            for (i = 0; i < M; i++) {
                for (j = 0; j < N; j++) {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
