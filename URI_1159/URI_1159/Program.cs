using System;

namespace URI_1159 {
    class Program {
        static void Main(string[] args) {
            int x, soma, cont;
            x = int.Parse(Console.ReadLine());
            soma = 0;

            while (x != 0) {
                if (x % 2 == 0) {
                    cont = 0;
                    while (cont < 5) {
                        soma = soma + x;
                        cont += 1;
                    }
                    Console.WriteLine(soma);
                } else {
                    cont = 0;
                    while (cont < 5) {
                        soma = soma + x + 1;
                        cont += 1;
                    }
                    Console.WriteLine(soma);
                }
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
