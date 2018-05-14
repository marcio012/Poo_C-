using System;

namespace poo_conceito_class
{
    class Triangulo
    {
        public double a, b, c;

        // metodo para calcular a area 
        public double area() 
        {
          double p = (a + b + c) / 2.0;
          return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
