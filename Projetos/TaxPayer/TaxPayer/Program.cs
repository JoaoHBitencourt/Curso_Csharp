using System.Globalization;
using TaxPayer.Entities;

namespace TaxPayer
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<TaxPayers> list = new List<TaxPayers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anual = double.Parse(Console.ReadLine(), CI);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double heralth = double.Parse(Console.ReadLine(), CI);
                    list.Add(new Individual(heralth, name, anual));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(employees, name, anual));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach (TaxPayers paid in list)
            {
                double tax = paid.Tax();
                Console.WriteLine($"{paid.Name}: $ {tax.ToString("F2", CI)}");
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CI)}");
            

        }
    }
}