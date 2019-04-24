using System.Collections.Generic;
using System.Globalization;
using System;

using Exercicio213.Entities;

// Fazer um programa para ler os dados de N produtos.
// Ao final mostrar a etiqueta de preco de cada produto.
// Todo produto possui nome e preco.
// Produtos importados possuem uma taxa da alfandega, e produtos usados possuem data de fabricacao.
// Estes dados devem ser acrescentados na etiqueta de preco.

namespace Exercicio213
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();
            while (true)
            {
                Console.WriteLine("Insert new Product? (y/n)");
                if (Console.ReadLine() == "n" ? true : false) break;
                Console.WriteLine();

                Console.WriteLine($"Product #{products.Count + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char t = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (t == 'c') products.Add(new Product(name, price));
                else if (t == 'i')
                {
                    Console.Write("Custom fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, fee));
                }
                else if (t == 'u')
                {
                    Console.Write("Manufacture date (dd/MM/yyyy): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
