using System.Globalization;
namespace Exercicio212.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        virtual public double Payment()
        {
            return Hours * ValuePerHour;
        }

        override public string ToString()
        {
            return $"{Name} - $ "
                + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}