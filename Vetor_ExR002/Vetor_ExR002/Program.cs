using System;
using System.Globalization;

namespace Vetor_ExR002 {
    class Program {
        static void Main(string[] args) {
            int n;
            double media, soma = 0.0;
            double[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for(int i= 0; i < n; i++) {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                soma += vet[i];
            }

            media = soma / n;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
