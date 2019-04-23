using System.Globalization;
namespace Exercicio206
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        private static double Taxa = 5.0;


        public ContaBancaria() { }
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double saldoInicial) : this(numero, titular)
        {
            Saldo = saldoInicial;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + Taxa;
        }

        override public string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}