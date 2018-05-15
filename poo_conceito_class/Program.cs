using System;
using System.Globalization;

namespace poo_conceito_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;
            double areaX, areaY;

            X = new Triangulo();
            Y = new Triangulo();

            X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // p = (X.a + X.b + X.c) / 2.0; // logica de calcular
            // areaX = Math.Sqrt(p * (p - X.a) * (p - X.b) * (p - X.c));
            areaX = X.area();

            // p = (Y.a + Y.b + Y.c) / 2.0;
            // areaY = Math.Sqrt(p * (p - Y.a) * (p - Y.b) * (p - Y.c));
            areaY = Y.area();

            Console.WriteLine("Area do Triangulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Triangulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) 
            {
                Console.WriteLine("Trinagulo de Maior area: X");
            } else if (areaY > areaX) {
                Console.WriteLine("Triangulo de Maior area: Y");
            } else {
                Console.WriteLine("Area Iguais");
            }

            Console.ReadLine();



        }
    }
}
