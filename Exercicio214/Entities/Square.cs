using System;

using Exercicio214.Entities.Enums;


namespace Exercicio214.Entities
{
    public class Square : Shape
    {
        public double Lenght { get; set; }

        public Square(Color color, double lenght) : base(color)
        {
            Lenght = lenght;
        }

        override public double Area()
        {
            return Math.Pow(Lenght, 2);
        }
    }
}