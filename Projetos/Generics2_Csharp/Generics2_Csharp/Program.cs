using Generics2_Csharp.Entities;
using Generics2_Csharp.Services;
using System.Globalization;

namespace Generics2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CI);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product p = calculationService.Max(list);

            Console.WriteLine("Most expensive:");
            Console.WriteLine(p);
        }
    }
}