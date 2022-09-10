using System;

namespace URI_1144 {
    class Program {
        static void Main(string[] args) {
            int n, x1, x2;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                x1 = i * i;
                x2 = i * i * i;
                Console.WriteLine(i + " " + x1 + " " + x2);
                Console.WriteLine(i + " " + (x1 + 1) + " " + (x2 + 1));
            }
        }
    }
}
