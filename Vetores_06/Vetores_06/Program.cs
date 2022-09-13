using System;

namespace Vetores_06 {
    class Program {
        static void Main(string[] args) {
            int n, idade = 0;
            n = int.Parse(Console.ReadLine());
            string maisVelho = "";
            string[] nomes = new string[n];
            int[] idades = new int[n];

            for(int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }

            for (int i = 0; i < n; i++) {
                if(idade < idades[i]) {
                    idade = idades[i];
                    maisVelho = nomes[i];
                }
            }

            Console.WriteLine("Pessoa mais velha: " + maisVelho);
        }
    }
}
