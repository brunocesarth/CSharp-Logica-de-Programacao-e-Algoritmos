using System;

namespace URI_1070_CORRECAO {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) {
                n = n + 1;
            }

            Console.WriteLine(n);
            Console.WriteLine(n + 2);
            Console.WriteLine(n + 4);
            Console.WriteLine(n + 6);
            Console.WriteLine(n + 8);
            Console.WriteLine(n + 10);
        }
    }
}
