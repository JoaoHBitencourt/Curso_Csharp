using EmployeeIComparable.Entities;

namespace EmployeeIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\temp\ws_Csharp\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee employee in list)
                    {
                        Console.WriteLine(employee);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}