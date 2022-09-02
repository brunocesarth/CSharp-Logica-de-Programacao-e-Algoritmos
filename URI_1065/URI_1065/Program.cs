using System;
using System.Globalization;

namespace URI_1065 {
    class Program {
        static void Main(string[] args) {
            double n1, n2, n3, n4, n5, contador = 0;
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n1 % 2 == 0) {
                contador += 1;
            }
            if (n2 % 2 == 0) {
                contador += 1;
            }
            if (n3 % 2 == 0) {
                contador += 1;
            }
            if (n4 % 2 == 0) {
                contador += 1;
            }
            if (n5 % 2 == 0) {
                contador += 1;
            }

            Console.WriteLine(contador + " valores pares");
        }
    }
}
