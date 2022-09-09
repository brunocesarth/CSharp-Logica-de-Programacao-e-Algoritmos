using System;

namespace URI_1133 {
    class Program {
        static void Main(string[] args) {
            int X, Y, resultado = 0, min, max;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X > Y) {
                min = Y;
                max = X;
            } else {
                min = X;
                max = Y;
            }

            for (int i = min + 1; i < max; i++) {
                if (i % 5 == 2 || i % 5 == 3) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
