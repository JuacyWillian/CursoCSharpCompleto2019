using System;
namespace Exercicio217.Entities.Exceptions
{
    public class WithdrawLimitException:ApplicationException
    {
        public WithdrawLimitException(string message): base(message){ }
    }
}
