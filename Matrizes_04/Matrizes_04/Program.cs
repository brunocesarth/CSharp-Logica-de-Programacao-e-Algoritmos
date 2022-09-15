﻿using System;

namespace Matrizes_04 {
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

            int soma = 0;
            for (i = 0; i < N; i++) {
                for (j = i + 1; j < N; j++) {
                    soma += matriz[i, j];
                }
            }

            Console.WriteLine(soma);
        }
    }
}
