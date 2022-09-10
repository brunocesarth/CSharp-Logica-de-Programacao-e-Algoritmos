using System;

namespace URI_1151 {
    class Program {
        static void Main(string[] args) {
            int i, n, x1, x2, x3;
            x1 = 0;
            x2 = 1;
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++) {
                if (i == n - 1) {
                    Console.WriteLine(x1);
                } else {
                    Console.Write(x1 + " ");
                }
                x3 = x2;
                x2 = x1;
                x1 = x3 + x2;
            }
        }
    }
}
