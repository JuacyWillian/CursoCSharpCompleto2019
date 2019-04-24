using System.Globalization;
using System.Collections.Generic;
using System;

using Exercicio214.Entities;
using Exercicio214.Entities.Enums;

// Faça um programa para ler os dados de N figuras.
// Depois mostrar as areas destas figuras.

namespace Exercicio214
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            while (true)
            {
                Console.Write("Insert new shape (y/n?) ");
                if (Console.ReadLine() == "n") break;
                // Console.Clear();

                Console.WriteLine($"Shape #{shapes.Count + 1} data: ");
                Console.Write("Rectangle, Circle or Square (r/c/s) ? ");
                string type = Console.ReadLine();

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine(), true);

                switch (type)
                {
                    case "r":
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        shapes.Add(new Rectangle(color, width, height));
                        break;

                    case "c":
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        shapes.Add(new Circle(color, radius));
                        break;

                    case "s":
                        Console.Write("Lenght: ");
                        double lenght = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        shapes.Add(new Square(color, lenght));
                        break;
                }
                Console.Clear();

            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape s in shapes)
            {
                Console.WriteLine(s.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
