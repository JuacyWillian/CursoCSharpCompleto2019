using System;

// Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

namespace Exercicio108
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) Console.WriteLine("PAR");
            else Console.WriteLine("IMPAR");

        }
    }
}
