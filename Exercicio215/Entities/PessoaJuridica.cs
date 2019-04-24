namespace Exercicio215.Entities
{
    public class PessoaJuridica : Contribuinte
    {
        public int Employees { get; set; }

        public PessoaJuridica(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            return (Employees < 10) ? AnualIncome * 0.16 : AnualIncome * 0.14;
        }
    }
}
