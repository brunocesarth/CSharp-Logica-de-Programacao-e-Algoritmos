using System;

namespace URI_1153 {
    class Program {
        static void Main(string[] args) {
            int N, result, X;
            result = 1;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N ; i++) {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
