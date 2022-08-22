using System;

namespace URI_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiorAb, a, b, c, maiorC;
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            maiorAb = (a + b + Math.Abs(a - b)) / 2;
            maiorC = (maiorAb + c + Math.Abs(maiorAb - c)) / 2;
            Console.WriteLine(maiorC + " eh o maior");
        }
    }
}
