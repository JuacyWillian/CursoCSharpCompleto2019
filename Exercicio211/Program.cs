using System.Globalization;
using System.Runtime.CompilerServices;
using System;

using Exercicio211.Entities;

// Ler os dados de um pedido com N items.
// Depois, mostrar um sumário do pedido conforme exemplo.
// Nota: o instante do pedido deve ser o instante do sistema: DateTimeConstantAttribute.Now


namespace Exercicio211
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (dd/MM/yyyy): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter order data: ");

            Console.Write("Order status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine(), true);

            Console.Write("How many items to this order? ");
            int nItems = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(client, status);

            for (int i = 0; i < nItems; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");

                Console.Write($"Product name: ");
                string pName = Console.ReadLine();

                Console.Write($"Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write($"Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());

                Product p = new Product(pName, pPrice);
                order.AddItem(new OrderItem(p, pQuantity));

                Console.WriteLine();
            }

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
