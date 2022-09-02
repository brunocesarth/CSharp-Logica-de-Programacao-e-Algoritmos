using System;
using System.Globalization;

namespace URI_1066 {
    class Program {
        static void Main(string[] args) {
            double n1, n2, n3, n4, n5, contadorPar = 0, contadorImpar = 0, contadorPositivo = 0, contadorNegativo = 0;
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n1 % 2 == 0) {
                contadorPar += 1;
            } else {
                contadorImpar += 1;
            }

            if (n2 % 2 == 0) {
                contadorPar += 1;
            } else {
                contadorImpar += 1;
            }

            if (n3 % 2 == 0) {
                contadorPar += 1;
            } else {
                contadorImpar += 1;
            }

            if (n4 % 2 == 0) {
                contadorPar += 1;
            } else {
                contadorImpar += 1;
            }

            if (n5 % 2 == 0) {
                contadorPar += 1;
            } else {
                contadorImpar += 1;
            }

            if (n1 > 0) {
                contadorPositivo += 1;
            } else if (n1 < 0) {
                contadorNegativo += 1;
            }

            if (n2 > 0) {
                contadorPositivo += 1;
            } else if (n2 < 0) {
                contadorNegativo += 1;
            }

            if (n3 > 0) {
                contadorPositivo += 1;
            } else if (n3 < 0) {
                contadorNegativo += 1;
            }

            if (n4 > 0) {
                contadorPositivo += 1;
            } else if (n4 < 0) {
                contadorNegativo += 1;
            }

            if (n5 > 0) {
                contadorPositivo += 1;
            } else if (n5 < 0) {
                contadorNegativo += 1;
            }

            Console.WriteLine(contadorPar + " valor(es) par(es)");
            Console.WriteLine(contadorImpar + " valor(es) impar(es)");
            Console.WriteLine(contadorPositivo + " valor(es) positivo(s)");
            Console.WriteLine(contadorNegativo + " valor(es) negativo(s)");
        }
    }
}
