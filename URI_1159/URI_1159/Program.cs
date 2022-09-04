using System;

namespace URI_1159 {
    class Program {
        static void Main(string[] args) {
            int x, soma, cont;
            x = int.Parse(Console.ReadLine());

            while (x != 0) {
                if (x % 2 == 0) {
                    cont = 0;
                    soma = 0;
                    while (cont < 5) {
                        soma = soma + x;
                        x += 2;
                        cont += 1;
                    }
                    Console.WriteLine(soma);
                    soma = 0;
                } else {
                    cont = 0;
                    soma = 0;
                    x = x + 1;
                    while (cont < 5) {
                        soma = soma + x;
                        x += 2;
                        cont += 1;
                    }
                    Console.WriteLine(soma);
                    soma = 0;
                }
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
