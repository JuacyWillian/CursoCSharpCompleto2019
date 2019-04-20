using System.Globalization;
using System;

// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o 
// valor da área deste círculo com quatro casas decimais conforme exemplos.
// Fórmula da área: area = π . raio 2
// Considere o valor de π = 3.14159

namespace Exercicio102
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double PI = 3.14159;

            double area = PI * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
