using System;

namespace URI_1071 {
    class Program {
        static void Main(string[] args) {
            int x, y, result = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y) {
                if (x % 2 == 1 || x % 2 == -1) {
                    for (int i = 0; y < x; i++) {
                        result += y;
                        Console.WriteLine(result);
                    }
                    Console.WriteLine(result);
                    y += 1;
                }
            }
        }
    }
}
