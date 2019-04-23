using System.Collections.Generic;
namespace Exercicio208
{
    public class Curso
    {
        public string Name { get; set; }
        public HashSet<int> Alunos { get; private set; }

        public Curso(string name)
        {
            Name = name;
            Alunos = new HashSet<int>();
        }
        public Curso(string name, HashSet<int> alunos) : this(name) { Alunos = alunos; }

        public void insertAluno(int codAluno) { Alunos.Add(codAluno); }
    }
}
