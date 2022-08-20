using System;
using System.Globalization;

namespace URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFunc, hrTrabalhadas;
            double valorHora, salario;
            numeroFunc = int.Parse(Console.ReadLine());
            hrTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = valorHora * hrTrabalhadas;
            Console.WriteLine("NUMBER = " + numeroFunc);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
