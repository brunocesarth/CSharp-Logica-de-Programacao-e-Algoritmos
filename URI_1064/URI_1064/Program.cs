using System;
using System.Globalization;

namespace URI_1064 {
    class Program {
        static void Main(string[] args) {
            double n1, n2, n3, n4, n5, n6, contador = 0, somador = 0, media;
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n1 > 0) {
                contador += 1;
                somador += n1;
            }
            if (n2 > 0) {
                contador += 1;
                somador += n2;
            }
            if (n3 > 0) {
                contador += 1;
                somador += n3;
            }
            if (n4 > 0) {
                contador += 1;
                somador += n4;
            }
            if (n5 > 0) {
                contador += 1;
                somador += n5;
            }
            if (n6 > 0) {
                contador += 1;
                somador += n6;
            }
            media = somador / contador;

            Console.WriteLine(contador + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
