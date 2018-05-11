using System;
using System.Globalization;

namespace dadosInline
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int y; 
            double z; 

            // vetor de string 
            string[] vet = Console.ReadLine().Split(' ');

            x = vet[0]; 
            y = int.Parse(vet[1]); // convert to int 
            z = double.Parse(vet[2], CultureInfo.InvariantCulture); // convet to double


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


        }
    }
}
