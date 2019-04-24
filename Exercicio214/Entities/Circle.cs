using System;

using Exercicio214.Entities.Enums;


namespace Exercicio214.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }
        override public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}