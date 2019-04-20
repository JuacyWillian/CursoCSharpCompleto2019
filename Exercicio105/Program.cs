using System.Globalization;
using System;

// Fazer um programa para ler o código de uma peça 1, o número de peças 1, 
// o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e 
// o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

namespace Exercicio105
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codPeca1 = int.Parse(vet[0]);
            int numPecas1 = int.Parse(vet[1]);
            double valorUnitario1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            int codPeca2 = int.Parse(vet[0]);
            int numPecas2 = int.Parse(vet[1]);
            double valorUnitario2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double aPagar = numPecas1 * valorUnitario1 + numPecas2 * valorUnitario2;

            Console.WriteLine("VALOR A PAGAR: R$ " + aPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
