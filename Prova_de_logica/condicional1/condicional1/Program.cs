using System.Globalization;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int cod, qtd;
            double valor;

            Console.WriteLine("Codigo do produto comprado: ");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("quantidade comprada: ");
            qtd = int.Parse(Console.ReadLine());

            valor = 0;
            switch (cod)
            {
                case 1:
                    valor = qtd * 4.00;
                    break;
                case 2:
                    valor = qtd * 4.50;
                    break;
                case 3:
                    valor = qtd * 5.00;
                    break;
                case 4:
                    valor = qtd * 2.00;
                    break;
                case 5:
                    valor = qtd * 1.50;
                    break;
            }

            Console.WriteLine("Total: R$ " + valor.ToString("F2", CI));

        }
    }
}