using System.Globalization;
namespace Exercicio205
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        private double NotaMinima = 60.0;
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= NotaMinima)
                return true;
            return false;
        }

        override public string ToString()
        {
            if (Aprovado())
            {
                return "APROVADO";
            }

            return "REPROVADO\nFALTARAM "
                + (NotaMinima - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS";
        }
    }
}
