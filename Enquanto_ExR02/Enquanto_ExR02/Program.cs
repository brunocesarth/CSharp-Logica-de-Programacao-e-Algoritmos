using System;
using System.Globalization;

namespace Enquanto_ExR02 {
    class Program {
        static void Main(string[] args) {
            int n, contador = 0;
            double result = 0;
            n = int.Parse(Console.ReadLine());

            if (n > 0) {
                while (n > 0) {
                    result += n;
                    contador += 1;
                    n = int.Parse(Console.ReadLine());
                }
                result = result / contador;
                Console.WriteLine(result.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("impossivel calcular");
            }
        }
    }
}
