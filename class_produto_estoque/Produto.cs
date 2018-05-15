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
            return "Dados do Produto "
                + nome + ", "
                + "R$ " + preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + quantidadeEmEstoque + " unidades, "
                + "Total: " + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) + ".";
        }


        public double valorTotalEmEstoque()
        {
            return preco * quantidadeEmEstoque;
        }

        public void realizarEntrada(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }

        public void realizarSaida(int quantidade)
        {
            if (quantidadeEmEstoque > quantidade)
            {
                quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
            } else {
                Console.WriteLine("Estoque insuficiente!");
            }
            
        }

    }
}