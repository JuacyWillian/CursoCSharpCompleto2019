using System.Globalization;
using System;

// Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem 
// dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) 
// este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, 
// deverá ser impressa a mensagem “Fora de intervalo”.

namespace Exercicio112
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (value >= 0 && value <= 25)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (value > 25 && value <= 50)
            {
                Console.WriteLine("Intervalo (25, 50]");
            }
            else if (value > 50 && value <= 75)
            {
                Console.WriteLine("Intervalo (50, 75]");
            }
            else if (value > 75 && value <= 100)
            {
                Console.WriteLine("Intervalo (75, 100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }

        }
    }
}
