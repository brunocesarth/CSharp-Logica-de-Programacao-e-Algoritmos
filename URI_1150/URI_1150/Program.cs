using System;

namespace URI_1150 {
    class Program {
        static void Main(string[] args) {
            int X, Z = 0, Y = 0, contador = 1, soma;
            X = int.Parse(Console.ReadLine());

            while (Z <= X) {
                Z = int.Parse(Console.ReadLine());
            }

            soma = X;
            do {
                X += 1;
                soma += X;
                contador += 1;
            } while (soma <= Z);

            Console.WriteLine(contador);
        }
    }
}
