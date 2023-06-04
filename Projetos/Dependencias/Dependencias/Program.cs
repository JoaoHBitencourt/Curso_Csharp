namespace Dependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            //Params
            int n1 = Calculator.Sum(2, 3);
            int n2 = Calculator.Sum(2, 3, 4);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
      
            //Modificador out
            Console.WriteLine();

            int a = 10;
            int triple;

            Calculator.TripleOut(a, out triple);
            Console.WriteLine(triple);

            //Modificador ref
            Console.WriteLine();

            int b = 10;
            Calculator.TripleRef(ref b);
            Console.WriteLine(b);
        }
    }
}