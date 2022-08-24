using System;

namespace URI_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int quociente, nota, valor, qtdNotas;
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine(valor);

            nota = 100;
            qtdNotas = valor / nota;
            quociente = valor % nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");

            nota = 50;
            qtdNotas = quociente / nota;
            quociente = quociente % nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");

            nota = 20;
            qtdNotas = quociente / nota;
            quociente = quociente % nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");

            nota = 10;
            qtdNotas = quociente / nota;
            quociente = quociente % nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");

            nota = 5;
            qtdNotas = quociente / nota;
            quociente = quociente % nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");

            nota = 2;
            qtdNotas = quociente / nota;
            quociente = quociente % nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");

            nota = 1;
            qtdNotas = quociente / nota;
            quociente = quociente % nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");
        }
    }
}
