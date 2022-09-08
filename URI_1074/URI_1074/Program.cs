using System;

namespace URI_1074 {
    class Program {
        static void Main(string[] args) {
            int N, X;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                X = int.Parse(Console.ReadLine());
                if (X < 0 && X % 2 == 0) {
                    Console.WriteLine("EVEN NEGATIVE");
                } else if (X > 0 && X % 2 == 0) {
                    Console.WriteLine("EVEN POSITIVE");
                } else if (X < 0 && X % 2 != 0) {
                    Console.WriteLine("ODD NEGATIVE");
                } else if (X > 0 && X % 2 != 0) {
                    Console.WriteLine("ODD POSITIVE");
                } else if (X == 0) {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
