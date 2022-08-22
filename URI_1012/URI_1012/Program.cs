using System;
using System.Globalization;

namespace URI_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, PI, trianguloRetangulo, circuloDeRaio, areaTrapezio, areaQuadrado, areaRetangulo;
            string[] vet = Console.ReadLine().Split(' ');
            PI = 3.14159;
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            trianguloRetangulo = (double)(A * C) / 2;
            circuloDeRaio = (double)PI * Math.Pow(C, 2);
            areaTrapezio = (double)((A + B) * C) / 2 ;
            areaQuadrado = B * B;
            areaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + trianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circuloDeRaio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
