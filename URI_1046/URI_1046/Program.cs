using System;

namespace URI_1046 {
    class Program {
        static void Main(string[] args) {
            int n1, n2, totalHoras = 0;
            string[] vet = Console.ReadLine().Split(' ');
            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);

            if (n1 < n2) {
                totalHoras = n2 - n1;
            } else if (n2 < n1) {
                totalHoras = (24 - n1) + n2;
            } else {
                totalHoras = 24;
            }
            Console.WriteLine("O JOGO DUROU " + totalHoras + " HORA(S)");
        }
    }
}
