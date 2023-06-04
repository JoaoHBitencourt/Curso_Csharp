using Lista1;
using System.Globalization;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<Employees> list = new List<Employees>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Emplyoee #{i+1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CI);
                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int id1 = int.Parse(Console.ReadLine());
            Employees employees = list.Find(x => x.Id == id1);
            if (employees != null)
            {
                Console.Write("Enter the percentage: ");
                double porcent = double.Parse(Console.ReadLine(), CI);
                employees.NewSalary(porcent);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("employee id does not exist");
                Console.WriteLine();
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employees item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}