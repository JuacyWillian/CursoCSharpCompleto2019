using System;

// Leia 2 valores inteiros (A e B). 
// Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", 
// indicando se os valores lidos são múltiplos entre si. 
// Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.

namespace Exercicio109
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a < b)
            {
                var aux = a;
                a = b;
                b = aux;
            }

            if (a % b == 0) Console.WriteLine("Sao Multiplos");
            else Console.WriteLine("Nao Sao Multiplos");

        }
    }
}
