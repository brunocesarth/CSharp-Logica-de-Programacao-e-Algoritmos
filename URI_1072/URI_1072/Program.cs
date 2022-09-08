using System;

namespace URI_1072 {
    class Program {
        static void Main(string[] args) {
            int N, X, contIn, contOut;
            N = int.Parse(Console.ReadLine());
            contIn = 0;
            contOut = 0;
            for (int i = 1; i <= N; i++) {
                X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20) {
                    contIn += 1;
                } else {
                    contOut += 1;
                }
            }
            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");
        }
    }
}
