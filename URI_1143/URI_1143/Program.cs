using System;

namespace URI_1143 {
    class Program {
        static void Main(string[] args) {
            int N, i, quadrado, cubo;
            N = int.Parse(Console.ReadLine());
            quadrado = 0;
            cubo = 0;


            for (i = 1; i <= N; i++) {
                quadrado = (int)Math.Pow(i, 2);
                cubo = (int)Math.Pow(i, 3);
                Console.WriteLine(i + " " + quadrado + " " + cubo);
            }
        }
    }
}
