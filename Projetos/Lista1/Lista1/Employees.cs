using System.Globalization;

namespace Lista1
{
    class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void NewSalary(double porcent)
        {
            Salary += Salary * porcent / 100;
        }

        public override string ToString()
        {
            return ($"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
