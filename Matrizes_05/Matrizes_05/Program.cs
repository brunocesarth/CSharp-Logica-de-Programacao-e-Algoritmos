using System;

namespace Matrizes_05 {
    class Program {
        static void Main(string[] args) {
            int N, M, i, j;
            int[,] A;
            int[,] B;
            int[,] C;
            string[] s = Console.ReadLine().Split(' ');
            N = int.Parse(s[0]);
            M = int.Parse(s[1]);

            A = new int[N, M];
            B = new int[N, M];
            C = new int[N, M];

            for (i = 0; i < N; i++) {
                s = Console.ReadLine().Split(' ');
                for (j = 0; j < M; j++) {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            for (i = 0; i < N; i++) {
                s = Console.ReadLine().Split(' ');
                for (j = 0; j < M; j++) {
                    B[i, j] = int.Parse(s[j]);
                }
            }

            for (i = 0; i < N; i++) {
                for (j = 0; j < M; j++) {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for (i = 0; i < N; i++) {
                for (j = 0; j < M; j++) {
                    Console.Write(C[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
