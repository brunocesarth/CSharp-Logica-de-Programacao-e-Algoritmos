using System;

namespace URI_1165 {
    class Program {
        static void Main(string[] args) {
            int i, n, x, c, contDiv;
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++) {
                x = int.Parse(Console.ReadLine());

                c = 1;
                contDiv = 0;
                while (x >= c) {
                    if (x % c == 0) {
                        contDiv += 1;
                    }
                    c += 1;
                }

                if (contDiv > 2) {
                    Console.WriteLine(x + " nao eh primo");
                } else {
                    Console.WriteLine(x + " eh primo");
                }
            }
        }
    }
}
