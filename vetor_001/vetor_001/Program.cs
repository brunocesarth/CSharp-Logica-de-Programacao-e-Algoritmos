using System;
using System.Globalization;

namespace vetor_001 {
    class Program {
        static void Main(string[] args) {
            int n, i;
            double[] vet;

            n = int.Parse(Console.ReadLine());

            vet = new double[n];

            for (i = 0; i < n; i++) {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (i = 0; i < n; i++) {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                ;
            }
        }
    }
}
