using System;

namespace URI_1049 {
    class Program {
        static void Main(string[] args) {
            string P1, P2, P3;
            P1 = Console.ReadLine();
            P2 = Console.ReadLine();
            P3 = Console.ReadLine();

            if (P1 == "vertebrado") {
                if (P2 == "ave") {
                    if (P3 == "carnivoro") {
                        Console.WriteLine("aguia");
                    } else if (P3 == "onivoro") {
                        Console.WriteLine("pomba");
                    }
                } else if (P2 == "mamifero") {
                    if (P3 == "onivoro") {
                        Console.WriteLine("homem");
                    } else if (P3 == "herbivoro") {
                        Console.WriteLine("vaca");
                    }
                }
            } else if (P1 == "invertebrado") {
                if (P2 == "inseto") {
                    if (P3 == "hematofago") {
                        Console.WriteLine("pulga");
                    } else if (P3 == "herbivoro") {
                        Console.WriteLine("lagarta");
                    }
                } else if (P2 == "anelideo") {
                    if (P3 == "hematofago") {
                        Console.WriteLine("sanguessuga");
                    } else if (P3 == "onivoro") {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
