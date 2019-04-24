using System.Globalization;
using System;
using System.Collections.Generic;

using Exercicio212.Entities;

// Uma empresa possui funcionarios proprios e terceirizados.
// Para cada funcionario, deseja-se registrar nome, horas trabalhadas e valor por hora. 
// Funcionarios terceirizados possuem ainda um despesa adicional.
// Os funcionarios terceirizados ainda recebem um bonus correspondente a 110% de dua despesa adicional.

// Faça um programa para ler os dados de N funcionarios e armazena-los em uma lista.
// Depois mostrar nome e pagamento de cada funcionario na mesma ordem em que foram digitados.

namespace Exercicio212
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int count = 0;
            while (true)
            {
                Console.Write("Register a new Employee: (s/n) ");
                if (Console.ReadLine().ToLower() == "n") break;

                count++;
                Employee employee;
                Console.WriteLine($"Employee #{count} data:");

                Console.Write("Outsourced (s/n)? ");
                bool outsource = (Console.ReadLine() == "s") ? true : false;

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsource)
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employee = new OutsourceEmployee(name, hours, valuePH, additionalCharge);
                }
                else
                {
                    employee = new Employee(name, hours, valuePH);
                }

                employees.Add(employee);
                Console.WriteLine();
            }

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }

        }
    }
}
