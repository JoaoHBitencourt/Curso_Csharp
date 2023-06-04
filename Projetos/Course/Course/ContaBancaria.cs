using System.Globalization;

namespace Course
{
    class ContaBancaria
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.00;
        }

        public override string ToString()
        {
            return ($"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CI)}");
        }

    }

}
