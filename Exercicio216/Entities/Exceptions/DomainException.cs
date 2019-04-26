using System;


namespace Exercicio216.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}