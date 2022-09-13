using System;
using System.Globalization;

namespace Vetores_05 {
    class Program {
        static void Main(string[] args) {
            int n, contador = 0;
            double soma, media ;
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) {
                vet[i] = int.Parse(s[i]);
            }

            soma = 0.0;

            for (int i = 0; i < n; i++) {
                if (vet[i] % 2 == 0) {
                    soma += (double)vet[i];
                    contador++;
                }
            }
            media =(double) soma / contador;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
