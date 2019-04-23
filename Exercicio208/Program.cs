using System.Collections.Generic;
using System;

namespace Exercicio208
{
    class Program
    {
        static void Main(string[] args)
        {

            Curso A = new Curso("A");
            Curso B = new Curso("B");
            Curso C = new Curso("C");
            Curso[] cursos = new Curso[] { A, B, C };

            foreach (var c in cursos)
            {

                Console.Write($"O curso {c.Name} possui quantos alunos? ");
                int qteAlunos = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite os codigos dos alunos do Curso {c.Name}:");
                for (int i = 0; i < qteAlunos; i++)
                    c.insertAluno(int.Parse(Console.ReadLine()));
            }

            HashSet<int> allAlunos = new HashSet<int>(A.Alunos);
            allAlunos.UnionWith(B.Alunos);
            allAlunos.UnionWith(C.Alunos);

            Console.WriteLine($"Total de alunos: {allAlunos.Count}");
        }
    }
}
