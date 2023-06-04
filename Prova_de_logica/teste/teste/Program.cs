using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os dados da peça 1 (código número valor):");
        string[] dadosPeca1 = Console.ReadLine().Split(' ');
        string codigoPeca1 = dadosPeca1[0];
        int numeroPeca1 = int.Parse(dadosPeca1[1]);
        double valorUnitarioPeca1 = double.Parse(dadosPeca1[2]);

        Console.WriteLine("Digite os dados da peça 2 (código número valor):");
        string[] dadosPeca2 = Console.ReadLine().Split(' ');
        string codigoPeca2 = dadosPeca2[0];
        int numeroPeca2 = int.Parse(dadosPeca2[1]);
        double valorUnitarioPeca2 = double.Parse(dadosPeca2[2]);

        double valorTotal = numeroPeca1 * valorUnitarioPeca1 + numeroPeca2 * valorUnitarioPeca2;

        Console.WriteLine("Valor total a ser pago: R$ " + valorTotal);
    }
}
