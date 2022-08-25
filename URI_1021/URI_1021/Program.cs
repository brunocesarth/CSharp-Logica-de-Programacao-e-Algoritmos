using System;
using System.Globalization;

namespace URI_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double quociente, nota, qtdNotas, valor, moeda, qtdMoedas;
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTAS:");

            nota = (int)100.00;
            qtdNotas = valor / nota;
            quociente = valor % nota;
            Console.WriteLine((int)qtdNotas + " nota(s) de R$ " + nota + ".00");

            nota = (int)50.00;
            qtdNotas = quociente / nota;
            quociente = quociente % nota;
            Console.WriteLine((int)qtdNotas + " nota(s) de R$ " + nota + ".00");

            nota = (int)20.00;
            qtdNotas = quociente / nota;
            quociente = quociente % nota;
            Console.WriteLine((int)qtdNotas + " nota(s) de R$ " + nota + ".00");

            nota = (int)10.00;
            qtdNotas = quociente / nota;
            quociente = quociente % nota;
            Console.WriteLine((int)qtdNotas + " nota(s) de R$ " + nota + ".00");

            nota = (int)5.00;
            qtdNotas = quociente / nota;
            quociente = quociente % nota;
            Console.WriteLine((int)qtdNotas + " nota(s) de R$ " + nota + ".00");

            nota = (int)2.00;
            qtdNotas = quociente / nota;
            quociente = quociente % nota;
            Console.WriteLine((int)qtdNotas + " nota(s) de R$ " + nota + ".00");

            Console.WriteLine("MOEDAS:");
            moeda = 1.00;
            qtdMoedas = quociente / moeda;
            quociente = quociente % moeda;
            Console.WriteLine((int)qtdMoedas + " moeda(s) de R$ " + moeda + ".00");

            moeda = 0.50;
            qtdMoedas = quociente / moeda;
            quociente = quociente % moeda;
            Console.WriteLine((int)qtdMoedas + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));

            moeda = 0.25;
            qtdMoedas = quociente / moeda;
            quociente = quociente % moeda;
            Console.WriteLine((int)qtdMoedas + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));

            moeda = 0.10;
            qtdMoedas = quociente / moeda;
            quociente = quociente % moeda;
            Console.WriteLine((int)qtdMoedas + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));

            moeda = 0.05;
            qtdMoedas = quociente / moeda;
            quociente = quociente % moeda;
            Console.WriteLine((int)qtdMoedas + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));

            moeda = 0.01;
            qtdMoedas = quociente / moeda;
            quociente = quociente % moeda;
            Console.WriteLine((int)qtdMoedas + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
