using System.Globalization;

namespace Estoque
{
    internal class Produto
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get 
            {
                return _nome; 
            }
            set
            {
                if (value != null && value.Length > 1) 
                {
                    _nome = value;
                }
            }

        }
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return ($"{Nome}, $ {Preco.ToString("F2", CI)}, {Quantidade} unidades, " +
                $"Total: $ {ValorTotalEmEstoque().ToString("F2", CI)}");
        }
    }
}
