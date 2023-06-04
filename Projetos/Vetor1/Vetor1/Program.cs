using System.Globalization;
using Vetor1;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CI);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0;
            for (int i = 0;i < n;i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine($"AVERAGE PRIECE = {avg.ToString("F2", CI)}");
        }
    }
}