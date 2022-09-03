using System;

namespace URI_1114 {
    class Program {
        static void Main(string[] args) {
            int tentativa, senha;
            tentativa = 0;
            senha = 2002;

            while (tentativa != senha) {
                tentativa = int.Parse(Console.ReadLine());
                if (tentativa != senha) {
                    Console.WriteLine("Senha Invalida");
                } else {
                    Console.WriteLine("Acesso Permitido");
                }
            }
        }
    }
}
