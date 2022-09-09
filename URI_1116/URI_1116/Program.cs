using System;
using System.Globalization;

namespace URI_1116 {
    class Program {
        static void Main(string[] args) {
            int N, X, Y;
            double resultado;
            string[] vet;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0], CultureInfo.InvariantCulture);
                Y = int.Parse(vet[1], CultureInfo.InvariantCulture);

                if (Y == 0) {
                    Console.WriteLine("divisao impossivel");
                } else {
                    resultado = (double) X / Y;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
