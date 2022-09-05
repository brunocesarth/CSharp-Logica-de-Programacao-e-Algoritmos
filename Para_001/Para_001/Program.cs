using System;

namespace Para_001 {
    class Program {
        static void Main(string[] args) {
            int n, x, soma = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                x = int.Parse(Console.ReadLine());
                soma += x;
            }
            Console.WriteLine(soma);

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Valor de i: " + i);
            }

            for (int i = 4; i >= 0; i--) {
                Console.WriteLine("Valor de i: " + i);
            }
        }
    }
}
