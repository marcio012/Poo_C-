using System;

namespace exercicio_fametro_quetao3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Moto moto = new Moto("Yamaha", "CBX", "Preta");


            Console.WriteLine("Informe a marca da Moto:");
            Console.Write("Marca: ");
            string marca = Console.ReadLine(); 

            Console.WriteLine("Informe o nome da Moto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a cor da Moto:");
            Console.Write("Cor: ");
            string cor = Console.ReadLine();

            Moto moto = new Moto(marca, nome, cor);            


            Console.WriteLine("Informe a marca da Moto:");
            Console.Write("Marca: ");
            marca = Console.ReadLine(); 

            Console.WriteLine("Informe o nome da Moto:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe a cor da Moto:");
            Console.Write("Cor: ");
            cor = Console.ReadLine();
            
            Console.WriteLine("Informe a macha da Moto:");
            Console.Write("Macha: ");
            int marcha = int.Parse(Console.ReadLine());

            Moto moto2 = new Moto(marca, nome, cor, marcha); 
            
            Console.WriteLine(moto);
            Console.WriteLine(moto.marcha);            
            Console.WriteLine(moto2);
            Console.WriteLine(moto2.marcha);

            moto2.toStringGetMarcha();
            Console.WriteLine("Reduzir Marcha");
            moto2.marchaAbaixo();
            Console.WriteLine(moto2);


            Console.WriteLine("Aumentar Marcha");
            moto2.marchaAcima();
            Console.WriteLine(moto2); 
            // Console.WriteLine(moto2.toStringGetMarcha());
        }
    }
}
