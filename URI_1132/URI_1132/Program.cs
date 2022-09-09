using System;

namespace URI_1132 {
    class Program {
        static void Main(string[] args) {
            int n1, n2, min, max, resultado = 0;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2) {
                min = n2;
                max = n1;
            } else {
                min = n1;
                max = n2;
            }

            for (int i = min; i <= max; i++) {
                if (i % 13 != 0) {
                    resultado += i;
                }
            }

            Console.WriteLine(resultado);
        }
    }
}
