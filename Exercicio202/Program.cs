using System.Globalization;
using System;

// Fazer um programa para ler nome e salário de dois funcionários. 
// Depois, mostrar o salário médio dos funcionários.

namespace Exercicio202
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;

            Console.WriteLine("Dados do primeiro funcionario:");
            f1 = new Funcionario();
            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");
            f2 = new Funcionario();
            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salMed = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salário médio: " + salMed.ToString("F2", CultureInfo.InvariantCulture));
        }


    }
}
