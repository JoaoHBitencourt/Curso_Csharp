using System.Globalization;

namespace Moeda
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantos dólares você vai comprar? ");
            double qte = double.Parse(Console.ReadLine(), CI);

            double resultado = ConversorDeMoeda.DolarParaReal(cot, qte);

            Console.WriteLine($"Valor a ser pago em reais = {resultado.ToString("F2", CI)}");
        }
    }
}