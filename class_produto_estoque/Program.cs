using System;
using System.Globalization;

namespace class_produto_estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto P;
            // P = new Produto();

            Console.WriteLine("Digite os dados do Produtos: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em Estoque: ");
            int quantidadeEmEstoque = int.Parse(Console.ReadLine());

            // contrutor 
            P = new Produto(nome, preco, quantidadeEmEstoque);

            // imprime na tela
            // Console.WriteLine("Você Digitou: " 
                                // + P.nome + ", " + P.preco.ToString("F2", CultureInfo.InvariantCulture) 
                                // + ", " + P.quantidadeEmEstoque + ".");

            Console.WriteLine("Você Digitou: " + P);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos que entraram no estoque: "); 
            int qte = int.Parse(Console.ReadLine());
            P.realizarEntrada(qte);
    
            Console.WriteLine();
            Console.WriteLine("Dados autualizados: " + P);
    
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos que saíram do estoque: "); 
            qte = int.Parse(Console.ReadLine());
            P.realizarSaida(qte);


            // P.quantidadeEmEstoque = 20;
            
            Console.WriteLine();
            Console.WriteLine("Dados autualizados: " + P);
            
            
            Console.ReadLine();                                

            
        }
    }
}
