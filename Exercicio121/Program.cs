using System.Globalization;
using System;

// Fazer um programa para ler um número N. 
// Depois leia N pares de números e mostre a divisão do primeiro pelo segundo. 
// Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

namespace Exercicio121
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

                if (b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine((a / b).ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
