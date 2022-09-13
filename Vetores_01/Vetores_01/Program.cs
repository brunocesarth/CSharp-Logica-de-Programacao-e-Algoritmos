using System;
using System.Globalization;

namespace Vetores_01 {
    class Program {
        static void Main(string[] args) {
            int n, posicao = 0;
            double maior = 0;
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++) {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                if (maior < vet[i]) {
                    maior = double.Parse(s[i], CultureInfo.InvariantCulture);
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}
