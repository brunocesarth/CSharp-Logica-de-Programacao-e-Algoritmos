using System;

namespace URI_1158 {
    class Program {
        static void Main(string[] args) {
            int N, X, Y, i, j, soma, C = 0;
            string[] vet;
            soma = 0;

            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= N; i++) {
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                while (C < Y) {
                    if (X % 2 != 0) {
                        soma += X;
                        C++;
                    }
                    X += 1;
                }

                Console.WriteLine(soma);
                soma = 0;
                C = 0;
            }
        }
    }
}
