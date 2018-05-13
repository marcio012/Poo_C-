using System;
using System.Globalization;

namespace estrutura_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, soma, cont;
            double media;

            idade = 0;
            soma = 0;
            cont = 0;

            idade = int.Parse(Console.ReadLine());

            if (idade >= 0) {

                while(idade >= 0) {
                    // idade = int.Parse(Console.ReadLine());
                    soma = soma + idade;
                    cont = cont + 1;
                    idade = int.Parse(Console.ReadLine());
                }
                
                media = (double) soma / cont; 
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            } else {
                Console.WriteLine("Impossivel Calcular.");
            }

            Console.ReadLine();
        }
    }
}
