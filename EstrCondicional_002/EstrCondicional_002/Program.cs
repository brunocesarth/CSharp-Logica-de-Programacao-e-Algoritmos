using System;
using System.Globalization;

namespace EstrCondicional_002 {
    class Program {
        static void Main(string[] args) {
            int N;
            double valorAPagar = 50.00;
            N = int.Parse(Console.ReadLine());

            if (N > 100) {
                valorAPagar += ((N - 100) * 2.00);
            }
            Console.WriteLine("Valor a pagar: R$ " + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
