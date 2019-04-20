using System.Globalization;
using System;

// Com base na tabela abaixo, escreva um programa que leia o 
// código de um item e a quantidade deste item. 
// A seguir, calcule e mostre o valor da conta a pagar.

namespace Exercicio111
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int prod = int.Parse(vet[0]);
            int qte = int.Parse(vet[1]);
            double total = 0;

            switch (prod)
            {
                case 1:
                    total = qte * 4.0;
                    break;
                case 2:
                    total = qte * 4.5;
                    break;
                case 3:
                    total = qte * 5.0;
                    break;
                case 4:
                    total = qte * 2.0;
                    break;
                case 5:
                    total = qte * 1.5;
                    break;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
