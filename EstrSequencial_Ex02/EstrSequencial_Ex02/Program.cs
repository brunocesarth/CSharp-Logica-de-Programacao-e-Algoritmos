using System;
using System.Globalization;

namespace EstrSequencial_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseRetangulo, alturaRetangulo, area, perimetro, diagonal;

            baseRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alturaRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = baseRetangulo * alturaRetangulo;
            perimetro = (baseRetangulo + alturaRetangulo) * 2;
            diagonal = Math.Sqrt((Math.Pow(baseRetangulo, 2) + Math.Pow(alturaRetangulo, 2)));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
