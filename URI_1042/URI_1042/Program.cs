using System;

namespace URI_1042 {
    class Program {
        static void Main(string[] args) {
            int n1, n2, n3, menor, meio, maior;
            string[] vet = Console.ReadLine().Split(' ');
            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);
            n3 = int.Parse(vet[2]);

            if (n1 < n2 && n1 < n3) {
                menor = n1;
                if (n2 < n3) {
                    meio = n2;
                    maior = n3;
                }
                else {
                    meio = n3;
                    maior = n2;
                }
            } else if (n2 < n3) {
                menor = n2;
                if (n1 < n3) {
                    meio = n1;
                    maior = n3;
                } else {
                    meio = n3;
                    maior = n1;
                }
            } else {
                menor = n3;
                if(n1 < n2) {
                    meio = n1;
                    maior = n2;
                } else {
                    meio = n2;
                    maior = n1;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
}
