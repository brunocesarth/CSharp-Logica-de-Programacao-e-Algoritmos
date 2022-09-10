using System;

namespace URI_1101 {
    class Program {
        static void Main(string[] args) {
            int m, n, min, max, i, soma = 0;
            string[] vet;

            do {
                vet = Console.ReadLine().Split(' ');
                m = int.Parse(vet[0]);
                n = int.Parse(vet[1]);

                if (m > n) {
                    min = n;
                    max = m;
                } else {
                    min = m;
                    max = n;
                }

                if (m > 0 && n > 0) {
                    for (i = min; i <= max; i++) {
                        soma += i;
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("Sum=" + soma);
                    soma = 0;
                }
            } while (m > 0 && n > 0);
        }
    }
}
