using System;
using System.Globalization;

namespace URI_1037 {
    class Program {
        static void Main(string[] args) {
            double n = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (n >= 0 && n <= 25.00) {
                Console.WriteLine("Intervalo [0,25]");
            } else if (n > 25.00 && n <= 50.00) {
                Console.WriteLine("Intervalo (25,50]");
            } else if (n > 50.00 && n <= 75.00) {
                Console.WriteLine("Intervalo (50,75]");
            } else if (n > 75.00 && n <= 100.00) {
                Console.WriteLine("Intervalo (75,100]");
            } else {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
