using System.Globalization;
using System;

namespace Exercicio206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero da copnta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            double saldoInicial = 0.0;
            Console.Write("Haverá depósito inicial? (s/n): ");
            string result = Console.ReadLine();
            if (result == "s")
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                saldoInicial = double.Parse(
                    Console.ReadLine(),
                    CultureInfo.InvariantCulture);
            }

            Console.WriteLine();
            ContaBancaria c = new ContaBancaria(numero, nome, saldoInicial);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c.ToString());
            Console.WriteLine();


            Console.Write("Entre com um valor para deposito: ");
            c.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c.ToString());
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            c.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c.ToString());
        }
    }
}
