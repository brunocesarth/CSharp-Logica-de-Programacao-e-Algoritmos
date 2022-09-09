using System;
using System.Globalization;

namespace URI_1094 {
    class Program {
        static void Main(string[] args) {
            int N, quantia, totalCobaias, ratos, sapos, coelhos;
            double porcentagemRatos, porcentagemSapos, porcentagemCoelhos;
            char animal;
            string[] vet;
            N = int.Parse(Console.ReadLine());
            totalCobaias = 0;
            ratos = 0;
            coelhos = 0;
            sapos = 0;

            for (int i = 1; i <= N; i++) {
                vet = Console.ReadLine().Split(' ');
                quantia = int.Parse(vet[0]);
                animal = char.Parse(vet[1]);

                totalCobaias += quantia;

                if (animal == 'C') {
                    coelhos += quantia;
                } else if (animal == 'S') {
                    sapos += quantia;
                } else if (animal == 'R') {
                    ratos += quantia;
                }
            }


            porcentagemCoelhos = (coelhos * 100.00) / totalCobaias;
            porcentagemRatos = (ratos * 100.00) / totalCobaias;
            porcentagemSapos = (sapos * 100.00) / totalCobaias;

            Console.WriteLine("Total: " + totalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
