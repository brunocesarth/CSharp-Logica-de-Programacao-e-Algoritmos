using System;

namespace URI_1131 {
    class Program {
        static void Main(string[] args) {
            int inter, gremio, resp, contGremio, contInter, contEmpate, qtdGrenais;
            resp = 1;
            contEmpate = 0;
            contInter = 0;
            contGremio = 0;

            while (resp == 1) {
                string[] vet = Console.ReadLine().Split(' ');
                inter = int.Parse(vet[0]);
                gremio = int.Parse(vet[1]);

                if (inter > gremio) {
                    contInter += 1;
                } else if (gremio > inter) {
                    contGremio += 1;
                } else if (gremio == 1) {
                    contEmpate += 1;
                }
                qtdGrenais = contInter + contGremio + contEmpate;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                resp = int.Parse(Console.ReadLine());
                if (resp == 2) {
                    Console.WriteLine(qtdGrenais + " grenais");
                    Console.WriteLine("Inter:" + contInter);
                    Console.WriteLine("Gremio:" + contGremio);
                    Console.WriteLine("Empates:" + contEmpate);
                    if (contGremio > contInter) {
                        Console.WriteLine("Gremio venceu mais");
                    } else if (contInter > contGremio) {
                        Console.WriteLine("Inter venceu mais");
                    } else {
                        Console.WriteLine("Nao houve vencedor");
                    }
                }
            }
        }
    }
}
