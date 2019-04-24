using Exercicio214.Entities.Enums;


namespace Exercicio214.Entities
{
    abstract public class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        abstract public double Area();
    }
}