using System;

namespace panda
{
    class Program
    {
        static void Main(string[] args)
        {
            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p2.Nome);

            Console.WriteLine(Panda.Population);
        }
    }
}
