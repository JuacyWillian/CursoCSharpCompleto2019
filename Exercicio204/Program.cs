using System.Globalization;
using System;

// Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). 
// Em seguida, mostrar os dados do funcionário (nome e salário líquido). 
// Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada 
// (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário. 
// Use a classe projetada abaixo.

// --------------------------------------------
//                Funcionario
// --------------------------------------------
// - Nome: string
// - SalarioBruto: double
// - Imposto: double
// --------------------------------------------
// + SalarioLiquido() -> double
// + AumentarSalario(porcentagem: double) -> void
// --------------------------------------------



namespace Exercicio204
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Funcionario: " + funcionario.ToString());
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("Dados Atualizados: " + funcionario.ToString());
        }

    }
}
