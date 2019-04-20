using System;


// Fazer um programa para ler quatro valores inteiros A, B, C e D. 
// A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D 
// segundo a fórmula: DIFERENCA = (A * B - C * D).


namespace Exercicio103
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int dif = a * b - c * d;

            Console.WriteLine($"DIFERENCA = {dif}");
        }
    }
}
