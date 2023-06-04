
using System.Globalization;

namespace Funcionario
{
    internal class Aumento
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem / 100);
        }

        public override string ToString()
        {
            return ($"{Nome}, $ {SalarioLiquido().ToString("F2", CI)}");

        }
    }
}
