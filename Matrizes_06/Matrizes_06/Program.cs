using System;
using System.Globalization;

namespace Matrizes_06 {
    class Program {
        static void Main(string[] args) {
            int N, i, j, indiceLinha, indiceColuna;
            double[,] matriz;
            N = int.Parse(Console.ReadLine());

            matriz = new double[N, N];
            for (i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (j = 0; j < N; j++) {
                    matriz[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            indiceLinha = int.Parse(Console.ReadLine());
            indiceColuna = int.Parse(Console.ReadLine());

            double soma = 0.0;
            for (i = 0; i < N; i++) {
                for (j = 0; j < N; j++) {
                    if (matriz[i, j] > 0) {
                        soma += matriz[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            double[] linha = new double[N];
            for (i = 0; i < N; i++) {
                for (j = 0; j < N; j++) {
                    linha[i] = matriz[indiceLinha, i];
                }
            }
            Console.Write("LINHA ESCOLHIDA: ");
            for (i = 0; i < N; i++) {
                Console.Write(linha[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            double[] coluna = new double[N];
            for (i = 0; i < N; i++) {
                for (j = 0; j < N; j++) {
                    coluna[i] = matriz[i, indiceColuna];
                }
            }
            Console.Write("COLUNA ESCOLHIDA: ");
            for (i = 0; i < N; i++) {
                Console.Write(coluna[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (i = 0; i < N; i++) {
                Console.Write(matriz[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA:");
            double[,] potencia = new double[N, N];
            for (i = 0; i < N; i++) {
                for (j = 0; j < N; j++) {
                    if (matriz[i, j] < 0) {
                        potencia[i, j] = Math.Pow(matriz[i, j], 2);
                        Console.Write(potencia[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    } else {
                        Console.Write(matriz[i,j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
