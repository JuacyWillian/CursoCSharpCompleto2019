using System.Globalization;
namespace Exercicio204
{
    class Funcionario
    {
        public double Salario, Imposto;
        public string Nome;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario + (Salario * (porcentagem / 100.0));
        }

        override public string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}