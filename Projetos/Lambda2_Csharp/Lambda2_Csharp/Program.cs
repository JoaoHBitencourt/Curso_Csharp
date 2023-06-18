using Lambda2_Csharp.Entities;
using System.Globalization;

namespace Lambda2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CI);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] employee = sr.ReadLine().Split(',');
                        string name = employee[0];
                        string email = employee[1];
                        double price = double.Parse(employee[2], CI);
                        list.Add(new Employee(name, email, price));
                    }
                }

                Console.WriteLine($"\nEmail of people whose salary is more than {salary.ToString("F2", CI)}:");
                var topSalary = list.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email).ToList();
                foreach (string email in topSalary)
                {
                    Console.WriteLine(email);
                }

                var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
                Console.Write($"\nSum of salary of people whose name starts with 'M': {sum.ToString("F2", CI)}\n");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}