using System;

namespace URI_1070 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) {
                n += 1;
                Console.WriteLine(n);
                for(int i = 0; i <= 4; i++) {
                    n += 2;
                    Console.WriteLine(n);
                }
            } else {
                Console.WriteLine(n);
                for (int i = 0; i <= 4; i++) {
                    n += 2;
                    Console.WriteLine(n);
                }
            }
        }
    }
}
