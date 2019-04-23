using System.Globalization;
using System;

using Exercicio209.Entities.Enums;
using Exercicio209.Entities;

// Ler os dados de um trabalhador com N contratos.
// Depois, solicitar do usuário um mês e mostrar qual foi o salário do 
// funcionario nesse mês.

namespace Exercicio209
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            Department department = new Department { Name = Console.ReadLine() };

            Console.WriteLine("Enter worket data: ");
            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine(), true);

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker w = new Worker(name, baseSalary, department, level);

            Console.Write("How many contracts to this worker? ");
            int nContracts = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < nContracts; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data:");
                Console.Write($"Date (DD/MM/YYYY): ");
                DateTime cDate = DateTime.Parse(Console.ReadLine());

                Console.Write($"Value per hour: ");
                double cValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write($"Duraction (hours): ");
                int cDuraction = int.Parse(Console.ReadLine());
                Console.WriteLine();

                HourContract contract = new HourContract
                {
                    Date = cDate,
                    ValuePerHour = cValuePerHour,
                    Hours = cDuraction
                };
                w.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] vet = Console.ReadLine().Split('/');
            double incomes = w.Income(int.Parse(vet[1]), int.Parse(vet[0]));

            Console.WriteLine(
                $"Name: {w}\n"
                + $"Department: {w.Department}\n"
                + $"Income for {string.Join('/', vet)}: "
                + incomes.ToString("F2", CultureInfo.InvariantCulture)
            );
        }
    }
}
