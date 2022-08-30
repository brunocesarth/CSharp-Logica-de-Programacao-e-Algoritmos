using System;
using System.Globalization;

namespace URI_1048 {
    class Program {
        static void Main(string[] args) {
            double salarioAtual, novoSalario, percentual, reajuste;
            salarioAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salarioAtual <= 400.00) {
                percentual = 15.00;
                novoSalario = salarioAtual + ((salarioAtual / 100.00) * percentual);
                reajuste = novoSalario - salarioAtual;
            } else if (salarioAtual >= 400.01 && salarioAtual <= 800.00) {
                percentual = 12.00;
                novoSalario = salarioAtual + ((salarioAtual / 100.00) * percentual);
                reajuste = novoSalario - salarioAtual;
            } else if (salarioAtual >= 800.01 && salarioAtual <= 1200.00) {
                percentual = 10.00;
                novoSalario = salarioAtual + ((salarioAtual / 100.00) * percentual);
                reajuste = novoSalario - salarioAtual;
            } else if (salarioAtual >= 1200.01 && salarioAtual <= 2000.00) {
                percentual = 7.00;
                novoSalario = salarioAtual + ((salarioAtual / 100.00) * percentual);
                reajuste = novoSalario - salarioAtual;
            } else {
                percentual = 4.00;
                novoSalario = salarioAtual + ((salarioAtual / 100.00) * percentual);
                reajuste = novoSalario - salarioAtual;
            }

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}
