using System;
using Exercicio216.Entities;
using Exercicio216.Entities.Exceptions;

// Fazer um programa para ler os dados de uma reserva de hotel(numero do quarto, 
// data de entrada e data de saida) e mostrar os dados da reserva, inclusive sua duração em dias.
// Em seguida, ler novas datas de entrada e de saida, atualizar a reserva, e mostrar 
// novamente a reserva com os dados atualizados.
// O programa nao deve aceitar dados invalidos para a reserva, conforme as seguintes regras:
//  - Alteracoes de reserva só podem ocorer para datas futuras
//  - A data de saida deve ser maior que a data de entrada

namespace Exercicio216
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Checkin: ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Checkout: ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Console.WriteLine();
                Reservation reservation = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine(reservation);

                Console.WriteLine();
                Console.WriteLine("Update Reservation");
                Console.Write("Checkin: ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Checkout: ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);

                Console.WriteLine();
                Console.WriteLine(reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine();
                Console.WriteLine($"Reservation error: {e.Message}");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye and have a nice day!");
            }
        }
    }
}
