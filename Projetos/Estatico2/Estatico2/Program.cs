
using Estatico2;
using System.Globalization;
namespace Estatico
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2", CI)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CI)}");
            Console.WriteLine($"Valor de PI: {calc.Pi.ToString("F2", CI)}");
        }
       
    }
}