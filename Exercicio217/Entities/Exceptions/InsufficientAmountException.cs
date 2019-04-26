using System;
namespace Exercicio217.Entities.Exceptions
{
    public class InsufficientAmountException:ApplicationException
    {
        public InsufficientAmountException(string message):base(message){}
    }
}
