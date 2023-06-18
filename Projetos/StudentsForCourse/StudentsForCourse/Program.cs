using StudentsForCourse.Entities;

namespace StudentsForCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Students> students = new HashSet<Students>();

            Console.Write("How many studentsfor course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                students.Add(new Students(x));
            }
            Console.Write("How many studentsfor course B? ");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                int x = int.Parse(Console.ReadLine());
                students.Add(new Students(x));
            }
            Console.Write("How many studentsfor course C? ");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n2; i++)
            {
                int x = int.Parse(Console.ReadLine());
                students.Add(new Students(x));
            }

            Console.WriteLine($"Total students: {students.Count}");
        }
    }
}