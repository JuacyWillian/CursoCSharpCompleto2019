﻿using System;

// Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, 
// um valor por linha, inclusive o X, se for o caso.

namespace Exercicio118
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
