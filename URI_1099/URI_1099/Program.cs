using System;

namespace URI_1099 {
    class Program {
        static void Main(string[] args) {
            int n, x, y, i, min, max, j, soma = 0;
            string[] vet;
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++) {
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x > y) {
                    min = y;
                    max = x;
                } else {
                    min = x;
                    max = y;
                }

                for (j = min+1; j < max; j++) {
                    if (j % 2 != 0) {
                        soma += j;
                    }
                }

                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}
