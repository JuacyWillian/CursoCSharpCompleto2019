using System;
using System.Globalization;

// Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres
// do ano(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). 
// Ao final, mostrar qual a nota final do aluno no ano.
// Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
// para o aluno obter o mínimo para ser aprovado(que é 60 pontos). 
// Você deve criar uma classe Aluno para resolver este problema.

namespace Exercicio205
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(a.ToString());

        }
    }
}
