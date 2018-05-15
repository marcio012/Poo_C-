using System; 
using System.Globalization;

namespace class_produto_estoque
{

    class Produto
    {
        // encapsulamento private
        // sem descrever o tipo e o mesmo que private 
        public string nome { get; private set; }
        public double preco {get; private set; }
        public int quantidadeEmEstoque {get; private set; }
        
        

        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = 0;
        }


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