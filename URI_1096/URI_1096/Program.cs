﻿using System;

namespace URI_1096 {
    class Program {
        static void Main(string[] args) {
            for (int i = 1; i <= 9; i = i + 2) {
                for (int j = 7; j >= 5; j--) {
                    Console.WriteLine("I=" + i + " " + "J=" + j);
                }
            }
        }
    }
}
