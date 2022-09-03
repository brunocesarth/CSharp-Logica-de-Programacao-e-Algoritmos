using System;

namespace URI_1134 {
    class Program {
        static void Main(string[] args) {
            int resp, gasolina, alcool, diesel;
            resp = int.Parse(Console.ReadLine());
            gasolina = 0;
            alcool = 0;
            diesel = 0;

            while (resp != 4) {
                resp = int.Parse(Console.ReadLine());
                if (resp == 1) {
                    alcool += 1;
                } else if (resp == 2) {
                    gasolina += 1;
                } else if (resp == 3) {
                    diesel += 1;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
