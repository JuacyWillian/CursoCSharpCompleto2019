namespace Exercicio212.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee() { }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        override public double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.10;
        }
    }
}