using System;

namespace URI_1071 {
    class Program {
        static void Main(string[] args) {
            int x, y, result = 0, i, min, max;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y) {
                min = x;
                max = y;
            } else {
                min = y;
                max = x;
            }

            for (i = min + 1; i < max; i++) {
                if (i % 2 != 0) {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }
}