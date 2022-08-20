using System;
using System.Globalization;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');
            int codPeca1 = int.Parse(peca1[0]);
            int qtdPeca1 = int.Parse(peca1[1]);
            double valorPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);
            int codPeca2 = int.Parse(peca2[0]);
            int qtdPeca2 = int.Parse(peca2[1]);
            double valorPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);
            double total = (qtdPeca1 * valorPeca1) + (qtdPeca2 * valorPeca2);
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
