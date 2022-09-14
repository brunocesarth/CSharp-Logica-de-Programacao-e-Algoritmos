using System;
using System.Globalization;

namespace Vetores_09 {
    class Program {
        static void Main(string[] args) {
            int i, n, lucro10, lucro10a20, lucro20;
            double totalCompra, totalVenda, lucroTotal, valorLucro;
            n = int.Parse(Console.ReadLine());
            lucro10 = 0;
            lucro10a20 = 0;
            lucro20 = 0;
            totalCompra = 0.0;
            totalVenda = 0.0;

            string[] produtos = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];

            for (i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                produtos[i] = s[0];
                precoCompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            for (i = 0; i < n; i++) {
                if (precoVenda[i] < precoCompra[i] + ((precoCompra[i] / 100.00) * 10.00)) {
                    lucro10++;
                } else if (precoVenda[i] >= precoCompra[i] + ((precoCompra[i] / 100.00) * 10.00)
                      && precoVenda[i] <= precoCompra[i] + ((precoCompra[i] / 100.00) * 20.00)) {
                    lucro10a20++;
                } else if (precoVenda[i] > precoCompra[i] + ((precoCompra[i] / 100.00) * 20.00)) {
                    lucro20++;
                }
            }

            for (i = 0; i < n; i++) {
                totalCompra += precoCompra[i];
            }

            for (i = 0; i < n; i++) {
                totalVenda += precoVenda[i];
            }

            lucroTotal = totalVenda - totalCompra;

            Console.WriteLine("Lucro abaixo de 10%: " + lucro10);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucro10a20);
            Console.WriteLine("Lucro acima de 20%: " + lucro20);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
