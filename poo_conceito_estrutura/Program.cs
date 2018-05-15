using System;
using System.Globalization;

namespace poo_conceito_estrutura
{
    class Program
    {
        static void Main(string[] args)
        {
            double aX, bX, cX, aY, bY, cY;
            double areaX, areaY, p;

            /*
            3.00
            4.00
            5.00
            7.50
            4.50
            4.02
            Area do Triangulo X: 6.0000
            Area do Triangulo Y: 7.5638
            Triangulo de Maior area: Y
             */

            aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (aX + bX + cX) / 2.0;
            areaX = Math.Sqrt(p * (p - aX) * (p - bX) * (p - cX));

            p = (aY + bY + cY) / 2.0;
            areaY = Math.Sqrt(p * (p - aY) * (p - bY) * (p - cY));

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
