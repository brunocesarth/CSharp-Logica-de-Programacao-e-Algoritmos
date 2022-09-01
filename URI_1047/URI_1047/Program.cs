using System;

namespace URI_1047 {
    class Program {
        static void Main(string[] args) {
            int horaInicial, minutoInicial, horaFinal, minutoFinal, horas = 0, minutos = 0, resto, tempoTotal = 0;
            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            if (horaInicial == horaFinal && minutoInicial == minutoFinal) {
                horas = 24;
            } else if (horaInicial < horaFinal) {
                tempoTotal = ((horaFinal - horaInicial) * 60) + (minutoFinal - minutoInicial);
            }
            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTO(S)");
        }
    }
}
