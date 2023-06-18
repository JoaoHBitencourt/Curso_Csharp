using System.Globalization;

namespace EmployeeIComparable.Entities
{
    class Employee : IComparable
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CI);
        }
        public override string ToString()
        {
            return $"{Name}, {Salary.ToString("F2", CI)}";
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}
