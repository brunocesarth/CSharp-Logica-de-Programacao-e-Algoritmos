using System;

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, ano, mes, dia, resto;
            valor = int.Parse(Console.ReadLine());
            ano = valor / 365;
            resto = valor % 365;
            mes = resto / 30;
            dia = resto % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
        }
    }
}
