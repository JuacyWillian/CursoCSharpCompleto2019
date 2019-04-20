using System;

// Leia a hora inicial e a hora final de um jogo. 
// A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia 
// e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

namespace Exercicio110
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int inicio = int.Parse(vet[0]);
            int fim = int.Parse(vet[1]);
            int duracao;

            if (inicio < fim)
                duracao = fim - inicio;
            else
                duracao = (24 - inicio) + fim;

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
