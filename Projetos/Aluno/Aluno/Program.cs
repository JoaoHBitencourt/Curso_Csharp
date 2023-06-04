using System.Globalization;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno:");
            aluno.N1 = double.Parse(Console.ReadLine(), CI);
            aluno.N2 = double.Parse(Console.ReadLine(),CI);
            aluno.N3 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"NOTA FINAL: {aluno.NotaFinal().ToString("F2", CI)}");

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno.NotaRestante().ToString("F2", CI)} PONTOS");
            }
        }
    }
}