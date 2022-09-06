using System;

namespace Para_ExR003 {
    class Program {
        static void Main(string[] args) {
            int n, result;
            n = int.Parse(Console.ReadLine());
            result = 0;

            for (int i = 1; i <= 10; i++) {
                result = (i * n);
                Console.WriteLine(i + " x " + n + " = " + result);
            }
        }
    }
}
