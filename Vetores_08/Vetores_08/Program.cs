using System;
using System.Globalization;

namespace Vetores_08 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double[] alturas = new double[n];
            string[] sexo = new string[n];
            double maiorAltura, menorAltura, mediaMulheres, soma = 0.0;
            int i, contadorMulheres, contadorHomens;
            maiorAltura = 0.0;
            contadorMulheres = 0;
            contadorHomens = 0;

            for (i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = (s[1]);
            }

            for (i = 0; i < n; i++) {
                if (maiorAltura < alturas[i]) {
                    maiorAltura = alturas[i];
                }
            }

            menorAltura = maiorAltura;
            for (i = 0; i < n; i++) {
                if (alturas[i] < menorAltura) {
                    menorAltura = alturas[i];
                }
            }

            for (i = 0; i < n; i++) {
                if (sexo[i] == "F") {
                    contadorMulheres++;
                } else {
                    contadorHomens++;
                }
            }

            for (i = 0; i < n; i++) {
                if (sexo[i] == "F") {
                    soma = (double)soma + alturas[i];
                }
            }

            mediaMulheres = (double)soma / contadorMulheres;

            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + mediaMulheres.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + contadorHomens);
        }
    }
}
