using System;

namespace EstrCondicional_001 {
    class Program {
        static void Main(string[] args) {
            int x = 5;
            Console.WriteLine("Bom dia!");

            if (x < 0) {
                Console.WriteLine("Boa tarde!");
            }

            Console.WriteLine("Boa noite!");

            int horas;
            Console.Write("Quantas horas?");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12) {
                Console.WriteLine("Bom dia!");
            } else if (horas < 18) {
                Console.WriteLine("Boa tarde!");
            } else {
                Console.WriteLine("Boa noite!");
            }

            Console.ReadLine();
        }
    }
}
