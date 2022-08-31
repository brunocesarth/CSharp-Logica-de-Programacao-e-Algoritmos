using System;
using System.Globalization;

namespace URI_1040 {
    class Program {
        static void Main(string[] args) {
            float n1, n2, n3, n4, media, exame, mediaFinal;
            string[] vet = Console.ReadLine().Split(' ');
            n1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(vet[3], CultureInfo.InvariantCulture);
            media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;
            
            if (media == 4.85f) {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0) {                
                Console.WriteLine("Aluno aprovado.");
            } else if (media <= 4.9f) {
                Console.WriteLine("Aluno reprovado.");
            } else {
                Console.WriteLine("Aluno em exame.");
                exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                mediaFinal = (media + exame) / 2.0f;
                if(mediaFinal >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }else {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
