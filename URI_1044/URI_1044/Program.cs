using System;

namespace URI_1044 {
    class Program {
        static void Main(string[] args) {
            int n1, n2;
            string[] vetor = Console.ReadLine().Split(' ');
            n1 = int.Parse(vetor[0]);
            n2 = int.Parse(vetor[1]);

            if (n1 % n2 == 0 || n2 % n1 == 0) {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
