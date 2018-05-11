using System;
using System.Globalization;

namespace app4_int
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int y;
            double z;
            char w;
            System.Console.WriteLine();
            x = Console.ReadLine();
            y = int.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            w = char.Parse(Console.ReadLine());

            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);
            System.Console.WriteLine(w);

            System.Console.WriteLine();
        }

    }
}
