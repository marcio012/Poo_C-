using System;
using System.Globalization;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.23423;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá Mundo ");
            Console.WriteLine("Bom Dia!!!");
            Console.WriteLine("Até mais."); 

            Console.WriteLine();
            System.Console.WriteLine(x);
            System.Console.WriteLine(x.ToString("F2"));
            System.Console.WriteLine(x.ToString("F4", CultureInfo.InvariantCulture));
            
            System.Console.WriteLine();
            System.Console.WriteLine("Resultado = " + x);
            System.Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            System.Console.WriteLine();
            System.Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            System.Console.WriteLine();


        }
    }
}
