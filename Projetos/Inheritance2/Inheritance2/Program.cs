
using Inheritance2.Entities;
using Microsoft.VisualBasic;
using System.Globalization;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char tag = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double priece = double.Parse(Console.ReadLine(), CI);
                if (tag == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(), CI);

                    list.Add(new ImportedProduct(name, priece, customs));
                }
                else if (tag == 'u')
                {             
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, priece, date));
                }
                else
                {
                    list.Add(new Product(name, priece));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}