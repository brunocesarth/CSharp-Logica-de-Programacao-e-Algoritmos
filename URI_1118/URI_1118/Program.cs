using System;
using System.Globalization;

namespace URI_1118 {
    class Program {
        static void Main(string[] args) {
            double n1, n2, media;
            int resp = 1;

            while (resp == 1) {
                if (resp == 1) {
                    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    while (n1 > 10.00 || n1 < 0.00) {
                        Console.WriteLine("nota invalida");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }

                    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    while (n2 > 10.0 || n2 < 0.0) {
                        Console.WriteLine("nota invalida");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }

                    media = (n1 + n2) / 2.0;

                    Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    resp = int.Parse(Console.ReadLine());
                    while (resp < 1 || resp > 2) {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        resp = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
    }
}
