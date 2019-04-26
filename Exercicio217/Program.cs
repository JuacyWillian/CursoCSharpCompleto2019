using System;
using System.Globalization;
using Exercicio217.Entities;

namespace Exercicio217
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                var acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(amount);
                Console.WriteLine("New Balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
