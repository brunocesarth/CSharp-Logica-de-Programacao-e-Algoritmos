using System;

namespace URI_1142 {
    class Program {
        static void Main(string[] args) {
            int N, x1, x2, x3, x5;
            string x4 = "PUM";
            N = int.Parse(Console.ReadLine());
            x1 = 1;
            x2 = x1 + 1;
            x3 = x2 + 1;

            for (int i = 0 + 1; i <= N; i++) {
                Console.WriteLine(x1 + " " + x2 + " " + x3 + " " + x4);
                x1 = x3 + 2;
                x2 = x1 + 1;
                x3 = x2 + 1;
            }
        }
    }
}
