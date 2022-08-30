using System;

namespace Condicionais_ExR03 {
    class Program {
        static void Main(string[] args) {
            int n1, n2, n3;
            string[] vetor = Console.ReadLine().Split(' ');
            n1 = int.Parse(vetor[0]);
            n2 = int.Parse(vetor[1]);
            n3 = int.Parse(vetor[2]);

            if (n1 < n2 && n1 < n3) {
                Console.WriteLine("MENOR = " + n1);
            } else if (n2 < n3) {
                Console.WriteLine("MENOR = " + n2);
            } else {
                Console.WriteLine("MENOR = " + n3);
            }
        }
    }
}
