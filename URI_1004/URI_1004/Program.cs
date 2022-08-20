using System;

namespace URI_1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, PROD;
            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());
            PROD = N1 * N2;
            Console.WriteLine("PROD = " + PROD);
        }
    }
}
