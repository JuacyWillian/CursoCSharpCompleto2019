using System;

// Faça um programa para ler dois valores inteiros, e depois mostrar na tela a 
// soma desses números com uma mensagem explicativa, conforme exemplos.

namespace Exercicio101
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int soma = a + b;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
