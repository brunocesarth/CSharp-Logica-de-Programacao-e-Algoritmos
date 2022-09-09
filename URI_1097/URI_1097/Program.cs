using System;

namespace URI_1097 {
    class Program {
        static void Main(string[] args) {
            int x, y;
            x = 5;
            y = 3;

            for (int i = 1; i <= 9; i += 2) {
                x += 2;
                y += 2;
                for (int j = x; j >= y; j--) {
                    Console.WriteLine("I=" + i + " " + "J=" + j);
                }
                
            }
        }
    }
}
