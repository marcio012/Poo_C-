using System;
using System.Globalization;


namespace exercicio_fametro_quetao3
{
    class Moto
    {
        public string marca { get; private set; }
        public string modelo { get; private set; }
        public string cor { get; private set; }
        public int marcha { get; private set; }

        public Moto (string marca, string modelo, string cor, int marcha)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.marcha = marcha; 
        }


        public Moto (string marca, string modelo, string cor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.marcha = 0;
        }


        public override string ToString()
        {
            return "Dados da Moto "
                + "Marca: " + marca + ", "
                + "Modelo: " + modelo + ", "
                + "Cor: " + cor + ", "
                + "Marcha: " + marcha +  ".";
                // + "Indicador da Macha " + caixaDeMacha(marcha);
        } 

        public void toStringGetMarcha() 
        {
            // marchaString = Console.WriteLine("Esta no vale");
            
            // /marchaStringN = Console.WriteLine("Não Esta no vale");

            if (this.marcha > 0 && this.marcha <= 6)
            {
                
                switch (this.marcha)
                {
                    case 1:
                        Console.WriteLine("Primeira Marcha");
                        break;
                    case 2:
                        Console.WriteLine("Segunda Marcha");
                        break;
                    case 3:
                        Console.WriteLine("Terceira Marcha");
                        break;
                    case 4:
                        Console.WriteLine("Quarta Marcha");
                        break;
                    case 5:
                        Console.WriteLine("Quinta Marcha");
                        break;
                    case 6:
                        Console.WriteLine("Sexta Marcha");
                        break;
                    default:
                        Console.WriteLine("Ponto Neutro");
                        break;
                }
            }
            else {
                // return marchaStringN;
                Console.WriteLine("Não Esta no vale");
            }


        }

        public void marchaAbaixo() {
            if (this.marcha <= 0)
            {
                Console.WriteLine("Não pode mais reduzir de marcha. ");
            }
            else {
                this.marcha = this.marcha - 1;
            }
        }

        public void marchaAcima() {
            
            if (this.marcha >= 6)
            {
                Console.WriteLine("Não pode passar de marcha. ");
            }
            else {
                this.marcha = this.marcha + 1;
            }
        }


    }
}
