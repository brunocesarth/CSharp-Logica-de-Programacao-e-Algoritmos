using System;
using System.Globalization;

namespace URI_1156 {
    class Program {
        static void Main(string[] args) {
            double s = 0.0, x = 1.0;

            for (int i = 1; i <= 39; i += 2) {
                s += i / x;
                x *= 2.0;
            }

            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
