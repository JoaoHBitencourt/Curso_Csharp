using System.Globalization;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double area, raio;
            double pi = 3.14159;

            Console.Write("Entre com o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CI);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Valor da area = " + area.ToString("F4", CI));



        }
    }
}