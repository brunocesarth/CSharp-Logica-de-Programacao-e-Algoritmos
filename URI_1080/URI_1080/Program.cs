using System;

namespace URI_1080 {
    class Program {
        static void Main(string[] args) {
            int x, posicao, n;
            x = 0;
            posicao = 0;

            for (int i = 1; i <= 100; i++) {
                n = int.Parse(Console.ReadLine());
                if (n > x) {
                    x = n;
                    posicao = i;
                }
            }
            Console.WriteLine(x);
            Console.WriteLine(posicao);
        }
    }
}
