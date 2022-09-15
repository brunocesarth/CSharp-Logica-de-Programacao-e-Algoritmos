using System;

namespace Matrizes_03 {
    class Program {
        static void Main(string[] args) {
            int N, i, j;
            int[,] matriz;
            N = int.Parse(Console.ReadLine());

            matriz = new int[N, N];

            for (i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            int[] vetor = new int[N];
            for(i = 0; i < N; i++) {
                int maior = 0;
                for(j = 0; j < N; j++) {
                    if (matriz[i, j] > maior) {
                        maior = matriz[i, j];
                    }
                    vetor[i] = maior;
                }
            }

            for (i=0; i < N; i++) {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
