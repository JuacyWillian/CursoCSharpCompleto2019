using System.Globalization;
using System;

// Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, 
// pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em 
// benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
// Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. 
// Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a 
// tabela abaixo.

// renda                   imposto
// 0       - 2000          0%
// 2000    - 3000          8%
// 3000    - 4500          18%
// 4500    - +             28%

// Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a 
// faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. 
// No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, 
// o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais

namespace Exercicio114
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (salario < 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario < 3000)
            {
                Console.WriteLine("R$ " + ((salario - 2000) * 0.08)
                    .ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario < 4500)
            {
                Console.WriteLine("R$ " + ((salario - 3000) * 0.18 + 1000 * 0.08)
                    .ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("R$ " + ((salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08)
                    .ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
