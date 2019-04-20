using System.Globalization;
using System;

// Fazer um programa que leia três valores com ponto flutuante de dupla precisão: 
// A, B e C.Em seguida, calcule e mostre:
// a) a área do triângulo retângulo que tem A por base e C por altura.
// b) a área do círculo de raio C. (pi = 3.14159)
// c) a área do trapézio que tem A e B por bases e C por altura.
// d) a área do quadrado que tem lado B.
// e) a área do retângulo que tem lados A e B.

namespace Exercicio106
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double areaTrianguloRet, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            areaTrianguloRet = a * c / 2;
            areaCirculo = 3.14159 * Math.Pow(c, 2);
            areaTrapezio = (a + b) * c / 2;
            areaQuadrado = b * b;
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTrianguloRet.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}
