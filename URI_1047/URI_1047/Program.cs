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
            } else if (horaInicial == horaFinal) {
                if (minutoInicial > minutoFinal) {
                    minutos = (60 + minutoFinal) - minutoInicial;
                    horas = 23;
                } else {
                    minutos = minutoFinal - minutoInicial;
                }
            } else if (horaInicial < horaFinal) {
                if (minutoInicial > minutoFinal) {
                    minutos = minutoFinal - minutoInicial;
                    tempoTotal = ((horaFinal - horaInicial) * 60) + minutos;
                } else {
                    tempoTotal = ((horaFinal - horaInicial) * 60) + (minutoFinal - minutoInicial);
                }
                horas = tempoTotal / 60;
                minutos = tempoTotal % 60;
            } else if (horaInicial > horaFinal) {
                if (minutoInicial > minutoFinal) {
                    minutos = (60 + minutoFinal) - minutoInicial;
                    tempoTotal = (((23 - horaInicial) + horaFinal)  * 60) + minutos;
                    horas = tempoTotal / 60;
                    minutos = tempoTotal % 60;
                } else {
                    tempoTotal = (((24 - horaInicial) + horaFinal) * 60) + minutoFinal - minutoInicial;
                    horas = tempoTotal / 60;
                    minutos = tempoTotal % 60;
                }
            }
            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTO(S)");
        }
    }
}
