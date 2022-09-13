using System;

namespace Vetores_03 {
    class Program {
        static void Main(string[] args) {
            int n;
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++) {
                a[i] = int.Parse(s[i]);
            }

            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++) {
                b[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < n; i++) {
                c[i] = a[i] + b[i];
            }

            for (int i = 0; i < n; i++) {
                Console.Write(c[i] + " ");
            }
        }
    }
}
