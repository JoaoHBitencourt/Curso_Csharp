using System.Globalization;

namespace Ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double preco = double.Parse(Console.ReadLine(), CI);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

        }
    }
}