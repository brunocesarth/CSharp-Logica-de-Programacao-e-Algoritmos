using System;
using System.Globalization;

namespace Vetores_07 {
    class Program {
        static void Main(string[] args) {
            int n, c = 0;
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];
            double[] media = new double[n];
            string[] aprovados = new string[n];

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                nota1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++) {
                media[i] = (nota1[i] + nota2[i]) / 2.0;
            }


            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < n; i++) {
                if (media[i] >= 6.0) {
                    aprovados[i] = nomes[i];
                    c++;
                    Console.WriteLine(aprovados[i]);

                }
            }
        }
    }
}
