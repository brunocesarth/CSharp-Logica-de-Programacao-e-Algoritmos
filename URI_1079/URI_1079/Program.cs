using System;
using System.Globalization;

namespace URI_1079 {
    class Program {
        static void Main(string[] args) {
            int N;
            double nota1, nota2, nota3, media;
            string[] vet;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                vet = Console.ReadLine().Split(' ');
                nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = ((2 * nota1) + (3 * nota2) + (5 * nota3)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
