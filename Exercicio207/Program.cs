using System;

namespace Exercicio207
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensao pensao = new Pensao();
            Console.Write("How mny rooms will be rented: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}:");
                Console.Write("Name: ");
                var nome = Console.ReadLine();

                Console.Write("Email: ");
                var email = Console.ReadLine();

                Console.Write("Room: ");
                int numero = int.Parse(Console.ReadLine());

                pensao.AlugarQuarto(numero, nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Busy Rooms:");
            Console.WriteLine(pensao);
        }
    }
}
