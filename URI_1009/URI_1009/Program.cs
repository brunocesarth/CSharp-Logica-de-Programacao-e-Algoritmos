using System;
using System.Globalization;

namespace URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, vendas, total;
            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            total = salarioFixo + ((vendas/100)*15);
            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
