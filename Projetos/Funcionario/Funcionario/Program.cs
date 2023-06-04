using System.Globalization;

namespace Funcionario
{

    class Program
    {
        static void Main(string[] args)
        {
           CultureInfo CI = CultureInfo.InvariantCulture;

            Aumento a = new Aumento();
            
            Console.Write("Nome:");
            a.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            a.SalarioBruto = double.Parse(Console.ReadLine(), CI);
            Console.Write("Imposto: ");
            a.Imposto = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine();
            Console.WriteLine($"Funcionario: {a}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine(), CI);
            a.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {a}");
        }
    }
}