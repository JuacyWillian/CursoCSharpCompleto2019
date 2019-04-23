using System;
namespace Exercicio209.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}