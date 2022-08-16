using System;

namespace Aula_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo 1");
            int x, y;
            x = 5;
            y = 2 * x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("Exemplo 2");
            int c;
            double d;
            c = 5;
            d = 2 * x;
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine("Exemplo 3");
            double b, B, h, area;
            b = 6.0;
            B = 8.0;
            h = 5.0;
            area = (b + B) / 2.0 * h;
            Console.WriteLine(area);

            Console.WriteLine("Exemplo 4");
            int a, e;
            double resultado;
            a = 5;
            e = 2;
            resultado = (double)a / e;
            Console.WriteLine(resultado);

            Console.WriteLine("Exemplo 5");
            double f;
            int g;
            f = 5.0;
            g = (int)f;
            Console.WriteLine(g);

        }
    }
}
