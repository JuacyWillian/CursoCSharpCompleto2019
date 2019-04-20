using System;

// Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de 
// pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. 
// O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA 
// (nesta situação sem escrever mensagem alguma).

namespace Exercicio116
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (x == 0 || y == 0)
                {
                    break;
                }
                else
                {
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                    else
                    {
                        Console.WriteLine("quarto");
                    }
                }
            }
        }
    }
}
