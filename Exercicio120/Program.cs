using System.Globalization;
using System;

// Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
// Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
// Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o 
// primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

namespace Exercicio120
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);
                double media = (a * 2 + b * 3 + c * 5) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
