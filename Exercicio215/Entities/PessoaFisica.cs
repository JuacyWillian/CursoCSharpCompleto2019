namespace Exercicio215.Entities
{
    public class PessoaFisica : Contribuinte
    {
        public double HealthExpenses { get; set; }

        public PessoaFisica(string name, double anualIncome, double healthExpense) : base(name, anualIncome)
        {
            HealthExpenses = healthExpense;
        }

        override public double Tax()
        {
            double tax = (AnualIncome < 20000) ? AnualIncome * 0.15 : AnualIncome * 0.25;
            return tax - HealthExpenses * 0.5;
        }
    }
}