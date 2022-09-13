using System;
using System.Globalization;

namespace Vetores_04 {
    class Program {
        static void Main(string[] args) {
            int n;
            double media, soma = 0.0; 
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++) {
                soma += vet[i];
            }

            media = (double) soma / n;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < n; i++) {
                if (vet[i] < media) {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
