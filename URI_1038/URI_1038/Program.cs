using System;
using System.Globalization;

namespace URI_1038 {
    class Program {
        static void Main(string[] args) {
            int item1, item2;
            double valor = 0;
            string[] vetor = Console.ReadLine().Split(' ');
            item1 = int.Parse(vetor[0]);
            item2 = int.Parse(vetor[1]);

            switch (item1) {
                case 1:
                    valor += 4.00 * item2;
                    break;
                case 2:
                    valor += 4.50 * item2;
                    break;
                case 3:
                    valor += 5.00 * item2;
                    break;
                case 4:
                    valor += 2.00 * item2;
                    break;
                case 5:
                    valor += 1.50 * item2;
                    break;
            }
            Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
