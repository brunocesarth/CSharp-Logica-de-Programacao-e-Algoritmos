using System;

namespace Vetores_02 {
    class Program {
        static void Main(string[] args) {
            int n, contador = 0;
            n = int.Parse(Console.ReadLine());
            
            int[] vet = new int[n];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) {
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < n; i++) {
                if (vet[i] % 2 == 0) {
                    Console.Write(vet[i] + " ");
                    contador++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(contador);
        }
    }
}
