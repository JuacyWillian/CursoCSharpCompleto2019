using System;

// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros 
// X que serão lidos em seguida.
// Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão 
// fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" 
// para dentro do intervalo, e "out" para fora do intervalo).

namespace Exercicio119
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int _in = 0, _out = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) _in++;
                else _out++;
            }

            Console.WriteLine($"{_in} in");
            Console.WriteLine($"{_out} out");

        }
    }
}
