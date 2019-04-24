using System;
using System.Collections.Generic;
using System.Globalization;

using Exercicio215.Entities;

// Ler dados de N contribuintes, que podem ser pessoa fisica ou pessoa juridica,
// depois calcular o imposto pago por cada um segundo as regras abaixo 
// e exibir o imposto de cada um e o todal de impostos pagos

// Pessoa Fisica
//      SalarioAnual                     imposto
//      <20.000,00           15% - (Gastos com saude %50)
//      => 20.000,00         25% - (Gastos com saude %50)

// Pessoa Juridica
//      Funcionarios                     imposto
//      <10                     16%
//      =>10                    14%

namespace Exercicio215
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> contribuintes = new List<Contribuinte>();
            while (true)
            {
                Console.Clear();
                Console.Write("Insert new contribuinte (y/n)? ");
                if (Console.ReadLine() == "n") break;

                Console.WriteLine();
                Console.WriteLine($"Tax payer #{contribuintes.Count} data:");

                Console.Write("Individual or company (i/c)? ");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    contribuintes.Add(new PessoaFisica(name, anualIncome, healthExpenses));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    contribuintes.Add(new PessoaJuridica(name, anualIncome, employees));
                }
            }

            Console.Clear();
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0.0;
            foreach (Contribuinte c in contribuintes)
            {
                Console.WriteLine($"{c.Name}: $ " + c.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += c.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
