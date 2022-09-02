using System;
using System.Globalization;

namespace URI_1051 {
    class Program {
        static void Main(string[] args) {
            double renda, valorImposto, valorImpostoDois;
            renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (renda < 2000.00) {
                Console.WriteLine("Isento");
            } else if (renda >= 2000.01 && renda <= 3000.00) {
                valorImposto = ((renda - 2000.00) / 100.00) * 8.00;
                Console.WriteLine("R$ " + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            } else if (renda >= 3000.01 && renda <= 4500.00) {
                valorImposto = ((renda - 2000.00 - (renda % 1000.00)) / 100.00 * 8.00) + (((renda % 1000.00) / 100.00) * 18.00);
                Console.WriteLine("R$ " + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                valorImposto = (renda - 4500);
                valorImpostoDois = (valorImposto /100) * 28.00;
                Console.WriteLine(valorImposto);
                Console.WriteLine(valorImpostoDois);

            }
        }
    }
}
