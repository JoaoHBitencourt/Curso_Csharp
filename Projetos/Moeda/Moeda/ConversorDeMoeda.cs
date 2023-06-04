namespace Moeda
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double DolarParaReal(double Cotacao, double Quantia)
        {
            double total = Quantia * Cotacao;
            return total + total * Iof / 100.0;
        }
        
    }
}
