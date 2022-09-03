using System;
using System.Globalization;

namespace URI_1154 {
    class Program {
        static void Main(string[] args) {
            int n, contador;
            double soma, media;
            soma = 0.00;
            media = 0.00;
            contador = 0;

            n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (n > 0) {
                soma += n;
                contador += 1;
                n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            media = soma / contador;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
