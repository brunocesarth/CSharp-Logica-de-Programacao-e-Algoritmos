using System;
using System.Globalization;

namespace URI_1045 {
    class Program {
        static void Main(string[] args) {
            double a, b, c;
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if ((a >= b + c) || (b >= c + a) || (c >= b + a)) {
                Console.WriteLine("NAO FORMA TRIANGULO");
            } else if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) || Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2) || Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2)) {
                Console.WriteLine("TRIANGULO RETANGULO");
            } else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2) ||
                Math.Pow(b, 2) > Math.Pow(a, 2) + Math.Pow(c, 2) || Math.Pow(c, 2) > Math.Pow(b, 2) + Math.Pow(a, 2)) {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            } else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2) || Math.Pow(b, 2) < Math.Pow(a, 2) + Math.Pow(c, 2) || Math.Pow(c, 2) < Math.Pow(b, 2) + Math.Pow(a, 2)) {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (a == b && b == c && a == c) {
                Console.WriteLine("TRIANGULO EQUILATERO");
            } else if ((a == b && a != c) || (a == c && b != c)) {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
