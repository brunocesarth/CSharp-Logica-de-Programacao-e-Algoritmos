using System;

namespace URI_1149 {
    class Program {
        static void Main(string[] args) {
            int a, n, i, soma;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);

            i = 1;
            n = int.Parse(vet[1]);
            while (n <= 0) {
                i += 1;
                n = int.Parse(vet[i]);
            }

            soma = 0;
            for (i = 0; i < n; i++) {
                soma += a + i;
            }

            Console.WriteLine(soma);
        }
    }
}
