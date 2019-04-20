using System;

// Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

namespace Exercicio107
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0) Console.WriteLine("NEGATIVO");
            else Console.WriteLine("NAO NEGATIVO");
        }
    }
}
