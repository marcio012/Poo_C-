using System; 
using System.Globalization;

namespace class_produto_estoque
{

    class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;


        public override string ToString() 
        {
            // return base.ToString();
            return nome
                + ", "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidadeEmEstoque
                + ".";
        }

    }
}