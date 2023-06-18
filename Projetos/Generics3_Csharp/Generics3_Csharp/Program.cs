using Generics3_Csharp.Entities;

namespace Generics3_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "Maria@gmail.com"};
            Client b = new Client { Name = "Alex", Email = "Maria@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}