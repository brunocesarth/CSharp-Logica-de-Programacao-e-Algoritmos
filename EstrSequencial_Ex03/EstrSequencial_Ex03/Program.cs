using System;
using System.Globalization;

namespace EstrSequencial_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            string[] pessoa = Console.ReadLine().Split(' ');
            string nome1 = pessoa[0];
            int idade1 = int.Parse(pessoa[1], CultureInfo.InvariantCulture);

            pessoa = Console.ReadLine().Split(' ');
            string nome2 = pessoa[0];
            int idade2 = int.Parse(pessoa[1], CultureInfo.InvariantCulture);

            media = (double) (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");
        }
    }
}
