using System.Globalization;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string[] dadosPeca1 = Console.ReadLine().Split(' ');
            string cod1 = dadosPeca1[0];
            int qtd1 = int.Parse(dadosPeca1[1]);
            double valor1 = double.Parse(dadosPeca1[2], CI);

            string[] dadosPeca2 = Console.ReadLine().Split(' ');
            string cod2 = dadosPeca2[0];
            int qtd2 = int.Parse(dadosPeca2[1]);
            double valor2 = double.Parse(dadosPeca2[2], CI);

            double total = qtd1 * valor1 + qtd2 * valor2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CI)}");
        }

    }
}
