using System;
namespace Exercicio217.Entities.Exceptions
{
    public class InsufficientBalanceException:ApplicationException
    {
        public InsufficientBalanceException(string message):base(message){ }
    }
}
