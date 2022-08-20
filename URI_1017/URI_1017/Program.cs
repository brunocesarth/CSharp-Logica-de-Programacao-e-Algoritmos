using System;
using System.Globalization;

namespace URI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoViagem, velocidadeMedia, distanciaPercorrida;
            double litrosTotais;
            tempoViagem = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());
            distanciaPercorrida = tempoViagem * velocidadeMedia;
            litrosTotais = distanciaPercorrida / 12.0;
            Console.WriteLine(litrosTotais.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
