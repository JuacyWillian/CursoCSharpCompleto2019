using System;

// Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. 
// Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 

// 1.Álcool 
// 2.Gasolina 
// 3.Diesel
// 4.Fim). 

// Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado 
// um novo código (até que seja válido). O programa será encerrado quando o código informado 
// for o número 4. Deve ser escrito a mensagem: 
// "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, 
// conforme exemplo.

namespace Exercicio117
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;
            bool sair = false;

            while (!sair)
            {
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        sair = true;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
