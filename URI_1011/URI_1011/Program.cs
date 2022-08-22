using System;
using System.Globalization;

namespace URI_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, volume, PI;
            PI = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            volume =(double) (4 / 3.0) * PI * Math.Pow(raio, 3);
            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
