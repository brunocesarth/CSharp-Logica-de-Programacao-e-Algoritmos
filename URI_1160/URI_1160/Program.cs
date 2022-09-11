using System;
using System.Globalization;

namespace URI_1160 {
    class Program {
        static void Main(string[] args) {
            int T, i, anos;
            double G1, G2, PA, PB;
            string[] vet;
            T = int.Parse(Console.ReadLine());

            for (i = 1; i <= T; i++) {
                vet = Console.ReadLine().Split(' ');
                PA = double.Parse(vet[0]);
                PB = double.Parse(vet[1]);
                G1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                G2 = double.Parse(vet[3], CultureInfo.InvariantCulture);

                for (anos = 0; PA <= PB; anos++) {
                    if (G2 == 0) {
                        PA += (PA / 100) * G1;
                    } else {
                        PA += (PA / 100) * G1;
                        PB += (PB / 100) * G2;
                    }
                }
                Console.WriteLine(anos + " anos");
            }
        }
    }
}
